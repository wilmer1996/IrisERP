﻿using System;
using System.Collections.Generic;
using System.Windows.Forms;
using IrisContabilidad.clases;
using IrisContabilidad.modelos;

namespace IrisContabilidad.clases_reportes
{
    public class reporte_compra_pago_agrupado_compra
    {
        public int codigoComrpa { get; set; }
        public string numeroCompra { get; set; }
        public string tipoCompra { get; set; }
        public string NCF { get; set; }
        public int codigoSuplidor { get; set; }
        public string suplidor { get; set; }
        public List<reporte_compra_pago_detalle> listaPagosDetalles { get; set; }

        public reporte_compra_pago_agrupado_compra()
        {
            
        }

        public reporte_compra_pago_agrupado_compra(compra compra)
        {
            try
            {
                suplidor suplidor = new modeloSuplidor().getSuplidorById(compra.cod_suplidor);
                this.codigoComrpa = compra.codigo;
                this.numeroCompra = compra.numero_factura;
                this.tipoCompra = compra.tipo_compra;
                this.NCF = compra.ncf;
                this.codigoSuplidor = suplidor.codigo;
                this.suplidor = suplidor.nombre;
                listaPagosDetalles=new List<reporte_compra_pago_detalle>();
                this.listaPagosDetalles = new reporte_compra_pago_detalle().getListaCompraVsPagosDetallesByCompraId(compra.codigo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error reporte_compra_pago_agrupado_compra.:" + ex.ToString(),"",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            
        }
    }
}
