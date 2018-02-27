﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_facturacion_normal
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_facturacion_normal));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.totalVentaText = new System.Windows.Forms.TextBox();
            this.totalItebisText = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.existenciaText = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.ItebisText = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.descuentoText = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.importeText = new System.Windows.Forms.TextBox();
            this.productoIdText = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.productoText = new System.Windows.Forms.TextBox();
            this.precioText = new System.Windows.Forms.TextBox();
            this.unidadComboText = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cantidadText = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.tipoComprobanteCombo = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.fechaFinalText = new System.Windows.Forms.MaskedTextBox();
            this.fechaInicialText = new System.Windows.Forms.MaskedTextBox();
            this.detalleText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tipoVentaComboBox = new System.Windows.Forms.ComboBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.numeroFacturaText = new System.Windows.Forms.TextBox();
            this.clienteText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.clienteIdText = new System.Windows.Forms.TextBox();
            this.numerocComprobanteFiscalText = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idPrductoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idUnidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itebisColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descuentoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.importeColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 777);
            this.panel1.Margin = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(1333, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1145, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(1365, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(573, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // totalVentaText
            // 
            this.totalVentaText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalVentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalVentaText.Location = new System.Drawing.Point(1149, 735);
            this.totalVentaText.Margin = new System.Windows.Forms.Padding(4);
            this.totalVentaText.MaxLength = 200;
            this.totalVentaText.Name = "totalVentaText";
            this.totalVentaText.ReadOnly = true;
            this.totalVentaText.Size = new System.Drawing.Size(199, 30);
            this.totalVentaText.TabIndex = 109;
            this.totalVentaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // totalItebisText
            // 
            this.totalItebisText.BackColor = System.Drawing.Color.SkyBlue;
            this.totalItebisText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalItebisText.Location = new System.Drawing.Point(837, 735);
            this.totalItebisText.Margin = new System.Windows.Forms.Padding(4);
            this.totalItebisText.MaxLength = 200;
            this.totalItebisText.Name = "totalItebisText";
            this.totalItebisText.ReadOnly = true;
            this.totalItebisText.Size = new System.Drawing.Size(197, 30);
            this.totalItebisText.TabIndex = 105;
            this.totalItebisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(1057, 738);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 25);
            this.label14.TabIndex = 108;
            this.label14.Text = "TOTAL";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(773, 738);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(56, 25);
            this.label13.TabIndex = 106;
            this.label13.Text = "TAX";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.existenciaText);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.ItebisText);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.button19);
            this.groupBox2.Controls.Add(this.button20);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.descuentoText);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.importeText);
            this.groupBox2.Controls.Add(this.productoIdText);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.productoText);
            this.groupBox2.Controls.Add(this.precioText);
            this.groupBox2.Controls.Add(this.unidadComboText);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.cantidadText);
            this.groupBox2.Location = new System.Drawing.Point(16, 343);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1335, 137);
            this.groupBox2.TabIndex = 107;
            this.groupBox2.TabStop = false;
            // 
            // existenciaText
            // 
            this.existenciaText.Location = new System.Drawing.Point(161, 107);
            this.existenciaText.Margin = new System.Windows.Forms.Padding(4);
            this.existenciaText.Name = "existenciaText";
            this.existenciaText.ReadOnly = true;
            this.existenciaText.Size = new System.Drawing.Size(143, 22);
            this.existenciaText.TabIndex = 107;
            this.existenciaText.Text = "0.00";
            this.existenciaText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.Location = new System.Drawing.Point(159, 80);
            this.label21.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(56, 20);
            this.label21.TabIndex = 106;
            this.label21.Text = "Stock";
            // 
            // ItebisText
            // 
            this.ItebisText.Location = new System.Drawing.Point(11, 107);
            this.ItebisText.Margin = new System.Windows.Forms.Padding(4);
            this.ItebisText.Name = "ItebisText";
            this.ItebisText.ReadOnly = true;
            this.ItebisText.Size = new System.Drawing.Size(143, 22);
            this.ItebisText.TabIndex = 105;
            this.ItebisText.Text = "0.00";
            this.ItebisText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(8, 80);
            this.label17.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(39, 20);
            this.label17.TabIndex = 104;
            this.label17.Text = "Tax";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(1261, 15);
            this.label16.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(44, 20);
            this.label16.TabIndex = 103;
            this.label16.Text = "(F2)";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1161, 15);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 20);
            this.label15.TabIndex = 102;
            this.label15.Text = "(F1)";
            // 
            // button19
            // 
            this.button19.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button19.BackgroundImage")));
            this.button19.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(1241, 39);
            this.button19.Margin = new System.Windows.Forms.Padding(4);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(85, 71);
            this.button19.TabIndex = 101;
            this.button19.UseVisualStyleBackColor = true;
            this.button19.Click += new System.EventHandler(this.button19_Click);
            // 
            // button20
            // 
            this.button20.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button20.BackgroundImage")));
            this.button20.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(1147, 39);
            this.button20.Margin = new System.Windows.Forms.Padding(4);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(87, 71);
            this.button20.TabIndex = 100;
            this.button20.UseVisualStyleBackColor = true;
            this.button20.Click += new System.EventHandler(this.button20_Click);
            this.button20.KeyDown += new System.Windows.Forms.KeyEventHandler(this.button20_KeyDown);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(289, 12);
            this.button4.Margin = new System.Windows.Forms.Padding(4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(44, 37);
            this.button4.TabIndex = 88;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // descuentoText
            // 
            this.descuentoText.Location = new System.Drawing.Point(821, 49);
            this.descuentoText.Margin = new System.Windows.Forms.Padding(4);
            this.descuentoText.MaxLength = 5;
            this.descuentoText.Name = "descuentoText";
            this.descuentoText.Size = new System.Drawing.Size(143, 22);
            this.descuentoText.TabIndex = 99;
            this.descuentoText.Text = "0.00";
            this.descuentoText.TextChanged += new System.EventHandler(this.descuentoText_TextChanged);
            this.descuentoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.descuentoText_KeyDown);
            this.descuentoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.descuentoText_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(5, 20);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 20);
            this.label7.TabIndex = 88;
            this.label7.Text = "Product ID";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(819, 20);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(114, 20);
            this.label12.TabIndex = 98;
            this.label12.Text = "Discount(%)";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(340, 19);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 20);
            this.label8.TabIndex = 89;
            this.label8.Text = "Unit (F5)";
            // 
            // importeText
            // 
            this.importeText.Location = new System.Drawing.Point(975, 49);
            this.importeText.Margin = new System.Windows.Forms.Padding(4);
            this.importeText.Name = "importeText";
            this.importeText.ReadOnly = true;
            this.importeText.Size = new System.Drawing.Size(143, 22);
            this.importeText.TabIndex = 97;
            this.importeText.Text = "0.00";
            this.importeText.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.importeText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.importeText_KeyDown);
            // 
            // productoIdText
            // 
            this.productoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.productoIdText.Location = new System.Drawing.Point(114, 18);
            this.productoIdText.Margin = new System.Windows.Forms.Padding(4);
            this.productoIdText.Name = "productoIdText";
            this.productoIdText.Size = new System.Drawing.Size(165, 22);
            this.productoIdText.TabIndex = 90;
            this.productoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.productoIdText_KeyDown);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(972, 20);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 20);
            this.label11.TabIndex = 96;
            this.label11.Text = "Total";
            // 
            // productoText
            // 
            this.productoText.Location = new System.Drawing.Point(8, 52);
            this.productoText.Margin = new System.Windows.Forms.Padding(4);
            this.productoText.Name = "productoText";
            this.productoText.ReadOnly = true;
            this.productoText.Size = new System.Drawing.Size(321, 22);
            this.productoText.TabIndex = 91;
            // 
            // precioText
            // 
            this.precioText.Location = new System.Drawing.Point(668, 49);
            this.precioText.Margin = new System.Windows.Forms.Padding(4);
            this.precioText.Name = "precioText";
            this.precioText.ReadOnly = true;
            this.precioText.Size = new System.Drawing.Size(143, 22);
            this.precioText.TabIndex = 95;
            this.precioText.Text = "0.00";
            this.precioText.TextChanged += new System.EventHandler(this.precioText_TextChanged);
            this.precioText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.precioText_KeyDown);
            this.precioText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.precioText_KeyPress);
            // 
            // unidadComboText
            // 
            this.unidadComboText.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.unidadComboText.FormattingEnabled = true;
            this.unidadComboText.Location = new System.Drawing.Point(344, 49);
            this.unidadComboText.Margin = new System.Windows.Forms.Padding(4);
            this.unidadComboText.Name = "unidadComboText";
            this.unidadComboText.Size = new System.Drawing.Size(161, 24);
            this.unidadComboText.TabIndex = 88;
            this.unidadComboText.Tag = "";
            this.unidadComboText.TextChanged += new System.EventHandler(this.unidadComboText_TextChanged);
            this.unidadComboText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unidadComboText_KeyDown);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(665, 20);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 20);
            this.label10.TabIndex = 94;
            this.label10.Text = "Precio";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(513, 18);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 20);
            this.label9.TabIndex = 92;
            this.label9.Text = "Quantity";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // cantidadText
            // 
            this.cantidadText.Location = new System.Drawing.Point(515, 49);
            this.cantidadText.Margin = new System.Windows.Forms.Padding(4);
            this.cantidadText.Name = "cantidadText";
            this.cantidadText.Size = new System.Drawing.Size(143, 22);
            this.cantidadText.TabIndex = 93;
            this.cantidadText.Text = "0";
            this.cantidadText.TextChanged += new System.EventHandler(this.cantidadText_TextChanged);
            this.cantidadText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.cantidadText_KeyDown);
            this.cantidadText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cantidadText_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label19);
            this.groupBox1.Controls.Add(this.label20);
            this.groupBox1.Controls.Add(this.tipoComprobanteCombo);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.fechaFinalText);
            this.groupBox1.Controls.Add(this.fechaInicialText);
            this.groupBox1.Controls.Add(this.detalleText);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tipoVentaComboBox);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Controls.Add(this.numeroFacturaText);
            this.groupBox1.Controls.Add(this.clienteText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.clienteIdText);
            this.groupBox1.Controls.Add(this.numerocComprobanteFiscalText);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1335, 303);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter_1);
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(485, 218);
            this.label19.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(107, 20);
            this.label19.TabIndex = 109;
            this.label19.Text = "Change(F4)";
            this.label19.Visible = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(36, 215);
            this.label20.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(111, 25);
            this.label20.TabIndex = 108;
            this.label20.Text = "Type NCF";
            this.label20.Click += new System.EventHandler(this.label20_Click);
            // 
            // tipoComprobanteCombo
            // 
            this.tipoComprobanteCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoComprobanteCombo.FormattingEnabled = true;
            this.tipoComprobanteCombo.Items.AddRange(new object[] {
            "CON",
            "COT",
            "CRE",
            "PED"});
            this.tipoComprobanteCombo.Location = new System.Drawing.Point(163, 215);
            this.tipoComprobanteCombo.Margin = new System.Windows.Forms.Padding(4);
            this.tipoComprobanteCombo.Name = "tipoComprobanteCombo";
            this.tipoComprobanteCombo.Size = new System.Drawing.Size(313, 24);
            this.tipoComprobanteCombo.TabIndex = 107;
            this.tipoComprobanteCombo.Tag = "";
            this.tipoComprobanteCombo.TextChanged += new System.EventHandler(this.tipoComprobanteCombo_TextChanged);
            this.tipoComprobanteCombo.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipoComprobanteCombo_KeyDown);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(485, 172);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(107, 20);
            this.label18.TabIndex = 106;
            this.label18.Text = "Change(F3)";
            this.label18.Visible = false;
            // 
            // fechaFinalText
            // 
            this.fechaFinalText.Location = new System.Drawing.Point(1133, 24);
            this.fechaFinalText.Margin = new System.Windows.Forms.Padding(4);
            this.fechaFinalText.Mask = "00/00/0000";
            this.fechaFinalText.Name = "fechaFinalText";
            this.fechaFinalText.Size = new System.Drawing.Size(165, 22);
            this.fechaFinalText.TabIndex = 89;
            this.fechaFinalText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaFinalText_KeyDown);
            // 
            // fechaInicialText
            // 
            this.fechaInicialText.Location = new System.Drawing.Point(705, 23);
            this.fechaInicialText.Margin = new System.Windows.Forms.Padding(4);
            this.fechaInicialText.Mask = "00/00/0000";
            this.fechaInicialText.Name = "fechaInicialText";
            this.fechaInicialText.Size = new System.Drawing.Size(165, 22);
            this.fechaInicialText.TabIndex = 88;
            this.fechaInicialText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaInicialText_KeyDown);
            // 
            // detalleText
            // 
            this.detalleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleText.Location = new System.Drawing.Point(705, 93);
            this.detalleText.Margin = new System.Windows.Forms.Padding(4);
            this.detalleText.MaxLength = 500;
            this.detalleText.Multiline = true;
            this.detalleText.Name = "detalleText";
            this.detalleText.Size = new System.Drawing.Size(593, 192);
            this.detalleText.TabIndex = 86;
            this.detalleText.Text = "Any description";
            this.detalleText.TextChanged += new System.EventHandler(this.detalleText_TextChanged);
            this.detalleText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detalleText_KeyDown);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(608, 89);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 25);
            this.label6.TabIndex = 85;
            this.label6.Text = "Details";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1007, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 25);
            this.label5.TabIndex = 84;
            this.label5.Text = "Final date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(549, 21);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 25);
            this.label4.TabIndex = 83;
            this.label4.Text = "Today\'s date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(44, 169);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 25);
            this.label1.TabIndex = 80;
            this.label1.Text = "Sale type";
            // 
            // tipoVentaComboBox
            // 
            this.tipoVentaComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoVentaComboBox.FormattingEnabled = true;
            this.tipoVentaComboBox.Location = new System.Drawing.Point(163, 170);
            this.tipoVentaComboBox.Margin = new System.Windows.Forms.Padding(4);
            this.tipoVentaComboBox.Name = "tipoVentaComboBox";
            this.tipoVentaComboBox.Size = new System.Drawing.Size(313, 24);
            this.tipoVentaComboBox.TabIndex = 79;
            this.tipoVentaComboBox.Tag = "";
            this.tipoVentaComboBox.TextChanged += new System.EventHandler(this.tipoVentaComboBox_TextChanged);
            this.tipoVentaComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipoVentaComboBox_KeyDown);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.LinkColor = System.Drawing.Color.Black;
            this.linkLabel1.Location = new System.Drawing.Point(42, 20);
            this.linkLabel1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(105, 25);
            this.linkLabel1.TabIndex = 78;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Customer";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // numeroFacturaText
            // 
            this.numeroFacturaText.BackColor = System.Drawing.Color.White;
            this.numeroFacturaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroFacturaText.Location = new System.Drawing.Point(163, 114);
            this.numeroFacturaText.Margin = new System.Windows.Forms.Padding(4);
            this.numeroFacturaText.MaxLength = 30;
            this.numeroFacturaText.Name = "numeroFacturaText";
            this.numeroFacturaText.ReadOnly = true;
            this.numeroFacturaText.Size = new System.Drawing.Size(313, 30);
            this.numeroFacturaText.TabIndex = 72;
            // 
            // clienteText
            // 
            this.clienteText.BackColor = System.Drawing.Color.White;
            this.clienteText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteText.Location = new System.Drawing.Point(163, 66);
            this.clienteText.Margin = new System.Windows.Forms.Padding(4);
            this.clienteText.MaxLength = 200;
            this.clienteText.Name = "clienteText";
            this.clienteText.ReadOnly = true;
            this.clienteText.Size = new System.Drawing.Size(313, 30);
            this.clienteText.TabIndex = 77;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 114);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 73;
            this.label2.Text = "Sale number";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(415, 16);
            this.button5.Margin = new System.Windows.Forms.Padding(4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 74;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(91, 256);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 25);
            this.label3.TabIndex = 76;
            this.label3.Text = "NCF";
            // 
            // clienteIdText
            // 
            this.clienteIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.clienteIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clienteIdText.Location = new System.Drawing.Point(163, 21);
            this.clienteIdText.Margin = new System.Windows.Forms.Padding(4);
            this.clienteIdText.Name = "clienteIdText";
            this.clienteIdText.Size = new System.Drawing.Size(243, 30);
            this.clienteIdText.TabIndex = 71;
            this.clienteIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.clienteIdText_KeyDown);
            // 
            // numerocComprobanteFiscalText
            // 
            this.numerocComprobanteFiscalText.BackColor = System.Drawing.Color.White;
            this.numerocComprobanteFiscalText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numerocComprobanteFiscalText.Location = new System.Drawing.Point(163, 254);
            this.numerocComprobanteFiscalText.Margin = new System.Windows.Forms.Padding(4);
            this.numerocComprobanteFiscalText.MaxLength = 19;
            this.numerocComprobanteFiscalText.Name = "numerocComprobanteFiscalText";
            this.numerocComprobanteFiscalText.ReadOnly = true;
            this.numerocComprobanteFiscalText.Size = new System.Drawing.Size(313, 30);
            this.numerocComprobanteFiscalText.TabIndex = 75;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idPrductoColumn,
            this.ProductoColumn,
            this.idUnidadColumn,
            this.unidadColumn,
            this.cantidadColumn,
            this.precioColumn,
            this.itebisColumn,
            this.descuentoColumn,
            this.importeColumn});
            this.dataGridView1.Location = new System.Drawing.Point(16, 487);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1335, 240);
            this.dataGridView1.TabIndex = 104;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idPrductoColumn
            // 
            this.idPrductoColumn.FillWeight = 50F;
            this.idPrductoColumn.HeaderText = "ID";
            this.idPrductoColumn.Name = "idPrductoColumn";
            this.idPrductoColumn.ReadOnly = true;
            // 
            // ProductoColumn
            // 
            this.ProductoColumn.HeaderText = "Product";
            this.ProductoColumn.Name = "ProductoColumn";
            this.ProductoColumn.ReadOnly = true;
            // 
            // idUnidadColumn
            // 
            this.idUnidadColumn.FillWeight = 50F;
            this.idUnidadColumn.HeaderText = "ID";
            this.idUnidadColumn.Name = "idUnidadColumn";
            this.idUnidadColumn.ReadOnly = true;
            // 
            // unidadColumn
            // 
            this.unidadColumn.HeaderText = "Unit";
            this.unidadColumn.Name = "unidadColumn";
            this.unidadColumn.ReadOnly = true;
            // 
            // cantidadColumn
            // 
            this.cantidadColumn.HeaderText = "Quantity";
            this.cantidadColumn.Name = "cantidadColumn";
            this.cantidadColumn.ReadOnly = true;
            // 
            // precioColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.precioColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.precioColumn.HeaderText = "Price";
            this.precioColumn.Name = "precioColumn";
            this.precioColumn.ReadOnly = true;
            // 
            // itebisColumn
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.itebisColumn.DefaultCellStyle = dataGridViewCellStyle2;
            this.itebisColumn.HeaderText = "Tax";
            this.itebisColumn.Name = "itebisColumn";
            this.itebisColumn.ReadOnly = true;
            // 
            // descuentoColumn
            // 
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.descuentoColumn.DefaultCellStyle = dataGridViewCellStyle3;
            this.descuentoColumn.HeaderText = "Discount";
            this.descuentoColumn.Name = "descuentoColumn";
            this.descuentoColumn.ReadOnly = true;
            // 
            // importeColumn
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.importeColumn.DefaultCellStyle = dataGridViewCellStyle4;
            this.importeColumn.HeaderText = "Total";
            this.importeColumn.Name = "importeColumn";
            this.importeColumn.ReadOnly = true;
            // 
            // ventana_facturacion_normal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1365, 858);
            this.Controls.Add(this.totalVentaText);
            this.Controls.Add(this.totalItebisText);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ventana_facturacion_normal";
            this.Text = "ventana_facturacion_normal";
            this.Load += new System.EventHandler(this.ventana_facturacion_normal_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ventana_facturacion_normal_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.label13, 0);
            this.Controls.SetChildIndex(this.label14, 0);
            this.Controls.SetChildIndex(this.totalItebisText, 0);
            this.Controls.SetChildIndex(this.totalVentaText, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox totalVentaText;
        private TextBox totalItebisText;
        private Label label14;
        private Label label13;
        private GroupBox groupBox2;
        private Label label16;
        private Label label15;
        private Button button19;
        private Button button20;
        private Button button4;
        private TextBox descuentoText;
        private Label label7;
        private Label label12;
        private Label label8;
        private TextBox importeText;
        private TextBox productoIdText;
        private Label label11;
        private TextBox productoText;
        private TextBox precioText;
        private ComboBox unidadComboText;
        private Label label10;
        private Label label9;
        private TextBox cantidadText;
        private GroupBox groupBox1;
        private MaskedTextBox fechaFinalText;
        private MaskedTextBox fechaInicialText;
        private TextBox detalleText;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label1;
        private ComboBox tipoVentaComboBox;
        private LinkLabel linkLabel1;
        private TextBox numeroFacturaText;
        private TextBox clienteText;
        private Label label2;
        private Button button5;
        private Label label3;
        private TextBox clienteIdText;
        private TextBox numerocComprobanteFiscalText;
        private DataGridView dataGridView1;
        private TextBox ItebisText;
        private Label label17;
        private Label label20;
        private ComboBox tipoComprobanteCombo;
        private TextBox existenciaText;
        private Label label21;
        private Label label19;
        private Label label18;
        private DataGridViewTextBoxColumn idPrductoColumn;
        private DataGridViewTextBoxColumn ProductoColumn;
        private DataGridViewTextBoxColumn idUnidadColumn;
        private DataGridViewTextBoxColumn unidadColumn;
        private DataGridViewTextBoxColumn cantidadColumn;
        private DataGridViewTextBoxColumn precioColumn;
        private DataGridViewTextBoxColumn itebisColumn;
        private DataGridViewTextBoxColumn descuentoColumn;
        private DataGridViewTextBoxColumn importeColumn;
    }
}