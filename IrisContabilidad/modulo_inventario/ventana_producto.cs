﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using IrisContabilidad.clases;
using IrisContabilidad.modelos;
using IrisContabilidad.modulo_facturacion;
using IrisContabilidad.modulo_sistema;

namespace IrisContabilidad.modulo_inventario
{
    public partial class ventana_producto : formBase
    {

        //objetos
        empleado empleadoSingleton;
        utilidades utilidades = new utilidades();
        singleton singleton = new singleton();
        empleado empleado;
        private producto producto;
        private itebis itebis;
        private unidad unidadMinima;
        private almacen almacen;
        private categoria_producto categoria;
        private subCategoriaProducto subCategoria;
        private unidad unidadCodigoBarra;
        private unidad unidadConversion;
        private producto productoTemporal;
        private productoUnidadConversion productoUnidadConversion;
        private producto_productos_requisitos productosRequisitos;
        private unidad unidadProduccion;
        private producto productoProduccion;

        //modelos
        private modeloItebis modeloItebis = new modeloItebis();
        private modeloUnidad modeloUnidad = new modeloUnidad();
        private modeloAlmacen modeloAlmacen = new modeloAlmacen();
        private modeloProducto modeloProducto = new modeloProducto();
        private modeloCategoriaProducto modeloCategoria = new modeloCategoriaProducto();
        private modeloSubCategoriaProducto modeloSubcategoria = new modeloSubCategoriaProducto();
        private producto_vs_codigobarra productoCodigoBarra;
        
        //variables
        private string rutaResources = "";
        private string rutaImagenesProductos = "";
        bool existe = false;//para saber si existe la unidad actual y el codigo de barra


        //listas
        private List<producto_vs_codigobarra> listaCodigoBarra;
        private List<productoUnidadConversion> listaProductoUnidadConversion;
        private List<producto_productos_requisitos> listaProductosRequisitos;

        public ventana_producto()
        {
            InitializeComponent();
            empleadoSingleton = singleton.getEmpleado();
            this.tituloLabel.Text = utilidades.GetTituloVentana(empleadoSingleton, "ventana producto");
            this.Text = tituloLabel.Text;
            rutaResources = Directory.GetCurrentDirectory().ToString() + @"\Resources\";
            rutaImagenesProductos = rutaResources + @"productos\";
            imagenProducto.BackgroundImage = Image.FromFile(rutaImagenesProductos + "default1.png");
            loadVentana();
        }
        public void loadVentana()
        {
            try
            {
                if (producto != null)
                {
                    //llenar campos
                    productoText.Focus();
                    productoText.SelectAll();

                    productoText.Text = producto.nombre;
                    referenciaText.Text = producto.referencia;
                    categoria = modeloCategoria.getCategoriaById(producto.codigo_categoria);
                    loadCategoria();
                    subCategoria = modeloSubcategoria.getSubCategoriaById(producto.codigo_subcategoria);
                    loadSubCategoria();
                    puntoMaximoText.Text = producto.punto_maximo.ToString("N");
                    puntoReordenText.Text = producto.reorden.ToString("N");
                    itebis = modeloItebis.getItebisById(producto.codigo_itebis);
                    loadItebis();
                    almacen = modeloAlmacen.getAlmacenById(producto.codigo_almacen);
                    loadAlmacen();
                    unidadMinima = modeloUnidad.getUnidadById(producto.codigo_unidad_minima);
                    loadUnidadMinima();
                    if (producto.imagen != "")
                    {
                        rutaImagenText.Text = rutaImagenesProductos + producto.imagen;
                        imagenProducto.BackgroundImage = Image.FromFile(rutaImagenesProductos + producto.imagen);
                    }
                    else
                    {
                        imagenProducto.BackgroundImage = Image.FromFile(rutaImagenesProductos + "default1.png");
                    }
                    activoCheck.Checked = Convert.ToBoolean(producto.activo);
                    listaCodigoBarra = modeloProducto.getListacodigoBarraById(producto.codigo);
                    listaProductoUnidadConversion = modeloProducto.getListaUnidadConversionById(producto.codigo);
                    loadProductoCodigoBarra();
                    loadUnidadProductoConversion();
                    listaProductosRequisitos = modeloProducto.getListaProductoRequisitos(producto.codigo);
                    loadProductosRequisitos();
                }
                else
                {
                    //blanquear campos
                    productoIdText.Focus();
                    productoIdText.SelectAll();

                    productoText.Text = "";
                    referenciaText.Text = "";
                    categoria = modeloCategoria.getCategoriaById(1);
                    loadCategoria();
                    subCategoria = modeloSubcategoria.getSubCategoriaById(1);
                    loadSubCategoria();
                    puntoMaximoText.Text = "0";
                    puntoReordenText.Text = "0";
                    itebis = modeloItebis.getItebisById(1);
                    loadItebis();
                    almacen = modeloAlmacen.getAlmacenById(1);
                    loadAlmacen();
                    unidadMinima = modeloUnidad.getUnidadById(1);
                    loadUnidadMinima();
                    rutaImagenText.Text = "";
                    imagenProducto.BackgroundImage = Image.FromFile(rutaImagenesProductos + "default1.png");
                    activoCheck.Checked = true;
                    unidadCodigoBarra = null;
                    loadUnidadCodigoBarra();
                    cantidadText.Text = "";
                    unidadIdPrecioVentaText.Text = "";
                    unidadPrecioVentaText.Text = "";
                    precioVentaText.Text = "";
                    precioCostoText.Text = "";

                    productoProduccionIdText.Text = "";
                    productoProduccionText.Text = "";
                    unidadProduccionIdText.Text = "";
                    unidadProduccionText.Text = "";
                    cantidadProduccionText.Text = "";


                    if (dataGridView1.Rows.Count > 0)
                    {
                        dataGridView1.Rows.Clear();
                    }
                    if (dataGridView2.Rows.Count > 0)
                    {
                        dataGridView2.Rows.Clear();
                    }
                    if (dataGridView3.Rows.Count > 0)
                    {
                        dataGridView3.Rows.Clear();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadVentana.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ventana_producto_Load(object sender, EventArgs e)
        {

        }

        public void loadProductosRequisitos()
        {
            try
            {
                if (listaProductosRequisitos == null)
                {
                    return;
                }
                if (dataGridView4.Rows.Count > 0)
                {
                    dataGridView4.Rows.Clear();
                }
                foreach (var x in listaProductosRequisitos)
                {
                    unidadProduccion = modeloUnidad.getUnidadById(x.codigo_unidad);
                    productoProduccion = modeloProducto.getProductoById(x.codigo_producto_requisito);
                    dataGridView4.Rows.Add(x.codigo_producto_requisito,productoProduccion.nombre, x.codigo_unidad, unidadProduccion.nombre,x.cantidad);
                }
                productoProduccion = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadProductosRequisitos.:" + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        public void loadItebis()
        {
            try
            {
                if (itebis == null)
                {
                    itebisIdText.Text = "";
                    itebisText.Text = "";
                    return;
                }
                itebisIdText.Text = itebis.codigo.ToString();
                itebisText.Text = itebis.nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadItebis.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public bool validarGetAction()
        {
            try
            {
                //validar nombre
                if (productoText.Text == "")
                {
                    MessageBox.Show("Falta el nombre", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    productoText.Focus();
                    productoText.SelectAll();
                    return false;
                }
                //validar itebis
                if (itebis==null)
                {
                    MessageBox.Show("Falta el itbis", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    itebisIdText.Focus();
                    itebisIdText.SelectAll();
                    return false;
                }
                //validar almacen
                if (almacen == null)
                {
                    MessageBox.Show("Falta el almacen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    almacenIdText.Focus();
                    almacenIdText.SelectAll();
                    return false;
                }
                //validar punto maximo
                if (puntoMaximoText.Text == "")
                {
                    MessageBox.Show("Falta el punto maximo", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    puntoMaximoText.Focus();
                    puntoMaximoText.SelectAll();
                    return false;
                }
                //validar punto reorden
                if (puntoReordenText.Text == "")
                {
                    MessageBox.Show("Falta el punto de reorden", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    puntoReordenText.Focus();
                    puntoReordenText.SelectAll();
                    return false;
                }
                //validar unidad minima
                if (unidadMinima == null)
                {
                    MessageBox.Show("Falta la unidad minima", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    unidadMinimaIdText.Focus();
                    unidadMinimaIdText.SelectAll();
                    return false;
                }

                //validar uniadades
                if (dataGridView3.Rows.Count < 1)
                {
                    MessageBox.Show("Falta establecer las unidades, para saber que cantidad sacar cada vez que se enda una", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tabPage4.Focus();
                    unidadIdPrecioVentaText.Focus();
                    unidadIdPrecioVentaText.SelectAll();
                    return false;
                }


                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error validarGetAction.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void GetAction()
        {
            try
            {
                if (MessageBox.Show("Desea guardar?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                if (!validarGetAction())
                {
                    return;
                }


                bool crear = false;
                if (producto == null)
                {
                    //agrega
                    crear = true;
                    producto = new producto();
                    producto.codigo = modeloProducto.getNext();
                }
                producto.nombre =productoText.Text;
                producto.referencia = referenciaText.Text;
                producto.activo = Convert.ToBoolean(activoCheck.Checked);
                producto.codigo_categoria = categoria.codigo;
                producto.codigo_subcategoria = subCategoria.codigo;
                producto.punto_maximo = Convert.ToDecimal(puntoMaximoText.Text);
                producto.reorden = Convert.ToDecimal(puntoReordenText.Text);
                producto.codigo_itebis = itebis.codigo;
                producto.codigo_almacen = almacen.codigo;
                producto.codigo_unidad_minima = unidadMinima.codigo;
                if (rutaImagenText.Text != "")
                {
                    producto.imagen = rutaImagenText.Text;
                }
                else
                {
                    producto.imagen = "";
                }
                if (crear)
                {
                    //agrega
                    if (modeloProducto.agregarProducto(producto) == true)
                    {
                        actualizarCodigoBarra();
                        actualizarUnidadConversion();
                        actualizarProductoProduccion();
                        producto = null;
                        listaCodigoBarra = null;
                        loadVentana();
                        MessageBox.Show("Se agregó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        producto = null;
                        MessageBox.Show("No se agregó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //actualiza
                    if (modeloProducto.modificarProducto(producto) == true)
                    {
                        actualizarCodigoBarra();
                        actualizarUnidadConversion();
                        actualizarProductoProduccion();
                        producto = null;
                        listaCodigoBarra = null;
                        loadVentana();
                        MessageBox.Show("Se modificó", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("No se modificó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                producto = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error GetAction.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button7_Click(object sender, EventArgs e)
        {
            ventana_busqueda_itbis ventana = new ventana_busqueda_itbis();
            ventana.mantenimiento = true;
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                itebis = ventana.getObjeto();
                loadItebis();
            }
        }

        public void actualizarCodigoBarra()
        {
            try
            {
                //borrar todos los codigo barra que son de este producto
                string sql = "delete from producto_vs_codigobarra where cod_producto='" + producto.codigo + "'";
                utilidades.ejecutarcomando_mysql(sql);
                //recorriendo la lista para agregarlo uno a uno
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    sql = "insert into producto_vs_codigobarra(cod_producto,cod_unidad,codigo_barra) values('" + producto.codigo + "','" + row.Cells[0].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "')";
                    utilidades.ejecutarcomando_mysql(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizarCodigoBarra.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroDecimal(e,puntoMaximoText.Text);
        }

        private void puntoReordenText_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroDecimal(e, puntoReordenText.Text);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                if (file.ShowDialog() == DialogResult.OK)
                {
                    rutaImagenText.Text = file.FileName;
                    imagenProducto.BackgroundImage = Image.FromFile(rutaImagenText.Text);
                }
            }
            catch (Exception)
            {
                rutaImagenText.Text = "";
                imagenProducto.BackgroundImage = Image.FromFile(rutaImagenesProductos + "default1.png");
                MessageBox.Show("Debe seleccionar una imagen", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }
        public void salir()
        {
            if (MessageBox.Show("Desea salir?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            salir();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            GetAction();
        }

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Desea eliminar la foto del empleado?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
                {
                    return;
                }

                rutaImagenText.Text = "";
                imagenProducto.BackgroundImage = Image.FromFile(rutaImagenesProductos + @"default1.png");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadAlmacen()
        {
            try
            {
                if (almacen == null)
                {
                    almacenIdText.Text = "";
                    almacenText.Text = "";
                    return;
                }
                almacenIdText.Text = almacen.codigo.ToString();
                almacenText.Text = almacen.nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadAlmacen.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            ventana_busqueda_almacen ventana = new ventana_busqueda_almacen();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                almacen = ventana.getObjeto();
                loadAlmacen();
            }
        }
        public void loadUnidadMinima()
        {
            try
            {
                if (unidadMinima == null)
                {
                    unidadMinimaIdText.Text = "";
                    unidadMinimaText.Text = "";
                    return;
                }
                unidadMinimaIdText.Text = unidadMinima.codigo.ToString();
                unidadMinimaText.Text = unidadMinima.nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadUnidad.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button10_Click(object sender, EventArgs e)
        {
            ventana_busqueda_unidad ventana = new ventana_busqueda_unidad();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                unidadMinima = ventana.getObjeto();
                loadUnidadMinima();
            }
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            producto = null;
            loadVentana();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            ventana_busqueda_categoria_producto ventana = new ventana_busqueda_categoria_producto();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                categoria = ventana.getObjeto();
                loadCategoria();
            }
        }
        public void loadCategoria()
        {
            try
            {
                if (categoria != null)
                {
                    categoriaIdText.Text = categoria.codigo.ToString();
                    categoriaText.Text = categoria.nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadCategoria.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadSubCategoria()
        {
            try
            {
                if (subCategoria != null)
                {
                    subcategoriaIdText.Text = subCategoria.codigo.ToString();
                    subCategoriaText.Text = subCategoria.nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadSubCategoria.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button6_Click(object sender, EventArgs e)
        {
            if (categoria == null)
            {
                MessageBox.Show("Falta la categoria", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                categoriaIdText.Focus();
                categoriaIdText.SelectAll();
                return;
            }
            ventana_busqueda_subcategoria_producto ventana = new ventana_busqueda_subcategoria_producto(categoria.codigo);
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                subCategoria = ventana.getObjeto();
                loadSubCategoria();
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            ventana_busqueda_producto ventana = new ventana_busqueda_producto(true);
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                producto = ventana.getObjeto();
                loadVentana();
            }
        }
        public void loadUnidadCodigoBarra()
        {
            try
            {
                if (unidadCodigoBarra == null)
                {
                    unidadIdCodigoBarraText.Text = "";
                    unidadTextCodigoBarra.Text = "";
                    return;
                }
                unidadIdCodigoBarraText.Text = unidadCodigoBarra.codigo.ToString();
                unidadTextCodigoBarra.Text = unidadCodigoBarra.nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadUnidadCodigoBarra.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button17_Click(object sender, EventArgs e)
        {
            ventana_busqueda_unidad ventana = new ventana_busqueda_unidad();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                unidadCodigoBarra = ventana.getObjeto();
                loadUnidadCodigoBarra();
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            eliminarcodigoBarra();
        }
        public void eliminarcodigoBarra()
        {
            try
            {
                //validar que tenga filas el datagrid
                if (dataGridView2.Rows.Count < 0)
                {
                    return;
                }
                int fila = 0;
                fila = dataGridView2.CurrentRow.Index;
                if (fila >= 0)
                {
                    listaCodigoBarra.RemoveAt(fila);
                    dataGridView2.Rows.Remove(dataGridView2.Rows[fila]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminarcodigoBarra.: " + ex.ToString(), "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            agregarCodigoBarra();
        }
        public void agregarCodigoBarra()
        {
            try
            {
                //validaciones

                //validar que ese codigo de barra no lo tenga otro producto
                if (codigoBarraText.Text != "")
                {
                    productoTemporal = modeloProducto.validarCodigoBarra(codigoBarraText.Text);
                    if (productoTemporal!=null)
                    {
                        MessageBox.Show("El código de barra ya lo tiene el producto.: " + productoTemporal.nombre, "",MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        productoTemporal = null;
                        return;
                    }
                    productoTemporal = null;
                }
                //validar que la lista no este nula
                if (listaCodigoBarra == null)
                {
                    listaCodigoBarra = new List<producto_vs_codigobarra>();
                }

                //validar tenga unidad
                if (unidadCodigoBarra == null)
                {
                    MessageBox.Show("Falta la unidad","", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    unidadIdCodigoBarraText.Focus();
                    unidadIdCodigoBarraText.SelectAll();
                    return;
                }

                //validar que tenga codigo de barra
                if (codigoBarraText.Text == "")
                {
                    MessageBox.Show("Falta la código de barra ", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    codigoBarraText.Focus();
                    codigoBarraText.SelectAll();
                    return;
                }

                existe = false;
                //validar que no se repita la unidad y el codigo de barra
                foreach (DataGridViewRow row in dataGridView2.Rows)
                {
                    if (row.Cells[0].Value.ToString()==unidadCodigoBarra.codigo.ToString() && row.Cells[2].Value.ToString()==codigoBarraText.Text.Trim())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe == false)
                {
                    dataGridView2.Rows.Add(unidadCodigoBarra.codigo.ToString(), unidadCodigoBarra.nombre,codigoBarraText.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregarCodigoBarra.: " + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        public void loadProductoCodigoBarra()
        {
            try
            {
                //validar que no tenga filas el datagrid
                if (dataGridView2.Rows.Count > 0)
                {
                    dataGridView2.Rows.Clear();
                }
                //validar lista no este nula
                if (listaCodigoBarra == null)
                {
                    return;
                }
                listaCodigoBarra.ForEach(x =>
                {
                    unidadCodigoBarra=new unidad();
                    unidadCodigoBarra = modeloUnidad.getUnidadById(x.codigo_unidad);
                    dataGridView2.Rows.Add(unidadCodigoBarra.codigo, unidadCodigoBarra.nombre, x.codigo_barra);
                });

                unidadCodigoBarra = null;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadProductoCodigoBarra.: " + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            ventana_busqueda_unidad ventana = new ventana_busqueda_unidad();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                unidadConversion = ventana.getObjeto();
                loadUnidadConversion();
                cantidadText.Focus();
                cantidadText.SelectAll();
            }
        }
        private void actualizarUnidadConversion()
        {
            try
            {
                //borrar todos los codigo barra que son de este producto
                string sql = "delete from producto_unidad_conversion where cod_producto='" + producto.codigo + "'";
                utilidades.ejecutarcomando_mysql(sql);
                //recorriendo la lista para agregarlo uno a uno
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    sql = "insert into producto_unidad_conversion(cod_producto,cod_unidad,cantidad,costo,precio_venta1) values('" + producto.codigo + "','" + row.Cells[0].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[3].Value.ToString() + "','" + row.Cells[4].Value.ToString() + "')";
                    utilidades.ejecutarcomando_mysql(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizarUnidadConversion.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void actualizarProductoProduccion()
        {
            try
            {
                //borrar todos los codigo barra que son de este producto
                string sql = "delete from producto_productos_requisitos where codpro_titular='" + producto.codigo + "'";
                utilidades.ejecutarcomando_mysql(sql);
                //recorriendo la lista para agregarlo uno a uno
                if (dataGridView4.Rows.Count > 0)
                {
                    producto.producto_titular = true;
                }
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    sql = "insert into producto_productos_requisitos(codpro_titular,codpro_requisito,cod_unidad,cantidad) values('" + producto.codigo + "','" + row.Cells[0].Value.ToString() + "','" + row.Cells[2].Value.ToString() + "','" + row.Cells[4].Value.ToString() + "')";
                    utilidades.ejecutarcomando_mysql(sql);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizarProductoProduccion.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadUnidadConversion()
        {
            try
            {
                if (unidadConversion == null)
                {
                    unidadIdPrecioVentaText.Text = "";
                    unidadPrecioVentaText.Text = "";
                    return;
                }
                unidadIdPrecioVentaText.Text = unidadConversion.codigo.ToString();
                unidadPrecioVentaText.Text = unidadConversion.nombre;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadUnidadConversion.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadUnidadProductoConversion()
        {
            try
            {
                //validar que no tenga filas el datagrid
                if (dataGridView3.Rows.Count > 0)
                {
                    dataGridView3.Rows.Clear();
                }
                //validar lista no este nula
                if (listaProductoUnidadConversion == null)
                {
                    return;
                }
                listaProductoUnidadConversion.ForEach(x =>
                {
                    unidadConversion = new unidad();
                    unidadConversion = modeloUnidad.getUnidadById(x.codigo_unidad);
                    dataGridView3.Rows.Add(unidadConversion.codigo, unidadConversion.nombre,x.cantidad,x.precio_costo.ToString("N"),x.precio_venta1.ToString("N"));
                });
                unidadConversion = null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadUnidadProductoConversion.: " + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }


        private void button20_Click(object sender, EventArgs e)
        {
            agregarUnidadConversion();
        }
        public void agregarUnidadConversion()
        {
            try
            {
                //validaciones

                //validar que tenga unidadConversion seleccionada
                if (unidadConversion==null)
                {
                    return;
                }
                //validar que tenga cantidad 
                if (cantidadText.Text == "")
                {
                    MessageBox.Show("Falta la cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    cantidadText.Focus();
                    cantidadText.SelectAll();
                    return;
                }
                //validar que tenga costo 
                if (precioCostoText.Text == "")
                {
                    MessageBox.Show("Falta el precio de costo", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    precioCostoText.Focus();
                    precioCostoText.SelectAll();
                    return;
                }
                //validar que tenga precio de venta 
                if (precioVentaText.Text == "")
                {
                    MessageBox.Show("Falta el precio de venta", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    precioVentaText.Focus();
                    precioVentaText.SelectAll();
                    return;
                }

                existe = false;
                //validar que no se repita la unidad
                foreach (DataGridViewRow row in dataGridView3.Rows)
                {
                    if (row.Cells[0].Value.ToString() == unidadConversion.codigo.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

                if (existe == false)
                {
                    dataGridView3.Rows.Add(unidadConversion.codigo.ToString(), unidadConversion.nombre, cantidadText.Text.Trim(), precioCostoText.Text.Trim(), precioVentaText.Text.Trim());
                }

                unidadPrecioVentaText.Focus();
                unidadPrecioVentaText.SelectAll();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregarUnidadConversion.: " + ex.ToString(), "", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            eliminarUnidadConversion();
        }
        public void eliminarUnidadConversion()
        {
            try
            {
                //validar que tenga filas el datagrid
                if (dataGridView3.Rows.Count < 0)
                {
                    return;
                }
                int fila = 0;
                fila = dataGridView3.CurrentRow.Index;
                if (fila >= 0)
                {
                    dataGridView3.Rows.Remove(dataGridView3.Rows[fila]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminarcodigoBarra.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cantidadText_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroDecimal(e,"");
        }

        private void precioCostoText_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroDecimal(e, "");
        }

        private void precioVentaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroDecimal(e, "");
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana_categoria_producto ventana=new ventana_categoria_producto();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana_subcategoria_producto ventana = new ventana_subcategoria_producto();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana_almacen ventana = new ventana_almacen();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana_unidad ventana = new ventana_unidad();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void productoText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {

                if (e.KeyCode == Keys.F1)
                {
                    button4_Click(null,null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    referenciaText.Focus();
                    referenciaText.SelectAll();
                }
            }
            catch (Exception)
            {
            }
        }

        private void referenciaText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                categoriaIdText.Focus();
                categoriaIdText.SelectAll();
            }
        }

        private void categoriaIdText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button5_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    subcategoriaIdText.Focus();
                    subcategoriaIdText.SelectAll();

                    categoria = modeloCategoria.getCategoriaById(Convert.ToInt16(categoriaIdText.Text));
                    loadCategoria();
                }
            }
            catch (Exception)
            {
            }
        }

        private void subcategoriaIdText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button6_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    puntoMaximoText.Focus();
                    puntoMaximoText.SelectAll();

                    subCategoria = modeloSubcategoria.getSubCategoriaById(Convert.ToInt16(subcategoriaIdText.Text));
                    loadSubCategoria();
                }
            }
            catch (Exception)
            {
            }
        }

        private void puntoMaximoText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
               
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    puntoReordenText.Focus();
                    puntoReordenText.SelectAll();

                }
            }
            catch (Exception)
            {
            }
        }

        private void puntoReordenText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    itebisIdText.Focus();
                    itebisIdText.SelectAll();

                }
            }
            catch (Exception)
            {
            }
        }

        private void itebisIdText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button7_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    almacenIdText.Focus();
                    almacenIdText.SelectAll();

                    itebis = modeloItebis.getItebisById(Convert.ToInt16(itebisIdText.Text));
                    loadItebis();
                }
            }
            catch (Exception)
            {
            }
        }

        private void almacenIdText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button8_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    unidadMinimaIdText.Focus();
                    unidadMinimaIdText.SelectAll();

                    almacen = modeloAlmacen.getAlmacenById(Convert.ToInt16(almacenIdText.Text));
                    loadAlmacen();
                }
            }
            catch (Exception)
            {
            }
        }

        private void unidadMinimaIdText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button9_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    rutaImagenText.Focus();
                    rutaImagenText.SelectAll();
                }
            }
            catch (Exception)
            {
            }
        }

        private void productoIdText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button4_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    productoText.Focus();
                    productoText.SelectAll();


                    producto = modeloProducto.getProductoById(Convert.ToInt16(productoIdText.Text));
                    loadVentana();
                }
            }
            catch (Exception)
            {
            }
        }

        private void rutaImagenText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button4_Click(null, null);
                }
                if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
                {
                    button1.Focus();
                }
            }
            catch (Exception)
            {
            }
        }

        public void actualizaProductosProduccion()
        {
            try
            {
                //para actualizar los productos que son requisitos para la fabricacion de este produco



            }
            catch (Exception ex)
            {
                MessageBox.Show("Error actualizaProductosProduccion.:" + ex.ToString(), "", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void cantidadProduccionText_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroDecimal(e,cantidadProduccionText.Text);
        }

        private void button23_Click(object sender, EventArgs e)
        {
            agregarProductoProduccion();
        }
        public void agregarProductoProduccion()
        {
            try
            {
                //validaciones

                //validar que tenga producto seleccionado
                if (productoProduccion == null)
                {
                    productoProduccionIdText.Focus();
                    productoProduccionIdText.SelectAll();
                    MessageBox.Show("Falta seleccionar el producto", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //validar que tenga unidadConversion seleccionada
                if (unidadProduccion == null)
                {
                    unidadProduccionIdText.Focus();
                    unidadProduccionIdText.SelectAll();
                    MessageBox.Show("Falta seleccionar la unidad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                //validar que tenga cantidad 
                if (cantidadProduccionText.Text == "")
                {
                    cantidadProduccionText.Focus();
                    cantidadProduccionText.SelectAll();
                    MessageBox.Show("Falta la cantidad", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                //validar que el producto no se tenga asi mismo como requisito
                if (productoProduccion.codigo == producto.codigo)
                {
                    MessageBox.Show("No puede seleccionar el mismo producto como requisito", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                existe = false;
                //validar que no se repita la unidad
                foreach (DataGridViewRow row in dataGridView4.Rows)
                {
                    if (row.Cells[0].Value.ToString() == productoProduccion.codigo.ToString() && row.Cells[2].Value.ToString()==unidadProduccion.codigo.ToString())
                    {
                        existe = true;
                        break;
                    }
                }

               


                //agregando al datagrid
                if (existe == false)
                {
                    dataGridView4.Rows.Add(productoProduccion.codigo.ToString(),productoProduccion.nombre, unidadProduccion.codigo,unidadProduccion.nombre, cantidadProduccionText.Text.Trim());
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error agregarUnidadConversion.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button22_Click(object sender, EventArgs e)
        {
            eliminarProductoProduccion();
        }
        public void eliminarProductoProduccion()
        {
            try
            {
                //validar que tenga filas el datagrid
                if (dataGridView4==null || dataGridView4.Rows.Count < 0)
                {
                    return;
                }
                int fila = 0;
                fila = dataGridView4.CurrentRow.Index;
                if (fila >= 0)
                {
                    dataGridView4.Rows.Remove(dataGridView4.Rows[fila]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error eliminarProductoProduccion.: " + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void loadProductoProduccion()
        {
            try
            {
                productoProduccionIdText.Text = "";
                productoProduccionText.Text = "";
                if (productoProduccion != null)
                {
                    productoProduccionIdText.Text = productoProduccion.codigo.ToString();
                    productoProduccionText.Text = productoProduccion.nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadProductoProduccion.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void loadUnidadProduccion()
        {
            try
            {
                unidadProduccionIdText.Text = "";
                unidadProduccionText.Text = "";
                if (unidadProduccion != null)
                {
                    unidadProduccionIdText.Text = unidadProduccion.codigo.ToString();
                    unidadProduccionText.Text = unidadProduccion.nombre;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loadUnidadProduccion.:" + ex.ToString(), "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void button21_Click(object sender, EventArgs e)
        {
            ventana_busqueda_producto ventana=new ventana_busqueda_producto();
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                productoProduccion = ventana.getObjeto();
                loadProductoProduccion();
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (productoProduccion == null)
            {
                productoProduccionIdText.Focus();
                productoProduccionIdText.SelectAll();
                MessageBox.Show("Fala seleccionar el producto");
                return;
            }
            ventana_busqueda_unidad ventana=new ventana_busqueda_unidad(productoProduccion.codigo);
            ventana.Owner = this;
            ventana.ShowDialog();
            if (ventana.DialogResult == DialogResult.OK)
            {
                unidadProduccion = ventana.getObjeto();
                loadUnidadProduccion();
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {
            
        }

        private void linkLabel5_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ventana_itebis ventana = new ventana_itebis();
            ventana.Owner = this;
            ventana.ShowDialog();
        }

        private void cantidadText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                precioCostoText.Focus();
                precioCostoText.SelectAll();
            }
        }

        private void precioCostoText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                precioVentaText.Focus();
                precioVentaText.SelectAll();
            }
        }

        private void precioVentaText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button20.Focus();
            }
        }

        private void unidadIdPrecioVentaText_KeyPress(object sender, KeyPressEventArgs e)
        {
            utilidades.validarTextBoxNumeroEntero(e);
        }

        private void unidadIdPrecioVentaText_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.F1)
                {
                    button18_Click(null,null);
                }
                if (e.KeyCode == Keys.Enter)
                {
                    unidadConversion = modeloUnidad.getUnidadById(Convert.ToInt16(unidadPrecioVentaText.Text));
                    if (unidadConversion != null)
                    {
                        loadUnidadConversion();
                        cantidadText.Focus();
                        cantidadText.SelectAll();    
                    }
                }
            }
            catch (Exception)
            {
                
            }
        }
    }
}
