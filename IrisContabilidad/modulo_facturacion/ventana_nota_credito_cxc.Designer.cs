﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_nota_credito_cxc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_nota_credito_cxc));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.notaCreditoIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.fechaText = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.conceptoComboBox = new System.Windows.Forms.ComboBox();
            this.montoText = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.detalleText = new System.Windows.Forms.TextBox();
            this.activoCheck = new System.Windows.Forms.CheckBox();
            this.button5 = new System.Windows.Forms.Button();
            this.ventaIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.NcfText = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.numeroVentaText = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radioButtonVenta = new System.Windows.Forms.RadioButton();
            this.radioButtonDevolucion = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(12, 459);
            this.panel1.Size = new System.Drawing.Size(888, 54);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(747, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Size = new System.Drawing.Size(912, 21);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(374, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.notaCreditoIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(12, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(888, 54);
            this.groupBox1.TabIndex = 74;
            this.groupBox1.TabStop = false;
            // 
            // notaCreditoIdText
            // 
            this.notaCreditoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.notaCreditoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notaCreditoIdText.Location = new System.Drawing.Point(204, 17);
            this.notaCreditoIdText.Name = "notaCreditoIdText";
            this.notaCreditoIdText.Size = new System.Drawing.Size(155, 26);
            this.notaCreditoIdText.TabIndex = 18;
            this.notaCreditoIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.notaCreditoIdText_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(88, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Nota Credito";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(365, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(47, 37);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 383);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 20);
            this.label3.TabIndex = 76;
            this.label3.Text = "Fecha";
            // 
            // fechaText
            // 
            this.fechaText.Location = new System.Drawing.Point(135, 386);
            this.fechaText.Mask = "00/00/0000";
            this.fechaText.Name = "fechaText";
            this.fechaText.Size = new System.Drawing.Size(155, 20);
            this.fechaText.TabIndex = 77;
            this.fechaText.ValidatingType = typeof(System.DateTime);
            this.fechaText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.fechaText_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(43, 297);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 20);
            this.label5.TabIndex = 83;
            this.label5.Text = "Concepto";
            // 
            // conceptoComboBox
            // 
            this.conceptoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.conceptoComboBox.FormattingEnabled = true;
            this.conceptoComboBox.Location = new System.Drawing.Point(135, 299);
            this.conceptoComboBox.Name = "conceptoComboBox";
            this.conceptoComboBox.Size = new System.Drawing.Size(236, 21);
            this.conceptoComboBox.TabIndex = 82;
            this.conceptoComboBox.Tag = "";
            this.conceptoComboBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.conceptoComboBox_KeyDown);
            // 
            // montoText
            // 
            this.montoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.montoText.Location = new System.Drawing.Point(135, 338);
            this.montoText.Name = "montoText";
            this.montoText.Size = new System.Drawing.Size(275, 26);
            this.montoText.TabIndex = 85;
            this.montoText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.montoText_KeyDown);
            this.montoText.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.montoText_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(70, 337);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 20);
            this.label6.TabIndex = 84;
            this.label6.Text = "Monto";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(521, 83);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 86;
            this.label7.Text = "Detalles";
            // 
            // detalleText
            // 
            this.detalleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalleText.Location = new System.Drawing.Point(525, 106);
            this.detalleText.MaxLength = 160;
            this.detalleText.Multiline = true;
            this.detalleText.Name = "detalleText";
            this.detalleText.Size = new System.Drawing.Size(370, 148);
            this.detalleText.TabIndex = 87;
            this.detalleText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.detalleText_KeyDown);
            // 
            // activoCheck
            // 
            this.activoCheck.AutoSize = true;
            this.activoCheck.Checked = true;
            this.activoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheck.Location = new System.Drawing.Point(525, 280);
            this.activoCheck.Name = "activoCheck";
            this.activoCheck.Size = new System.Drawing.Size(71, 21);
            this.activoCheck.TabIndex = 88;
            this.activoCheck.Text = "Activo";
            this.activoCheck.UseVisualStyleBackColor = true;
            this.activoCheck.KeyDown += new System.Windows.Forms.KeyEventHandler(this.activoCheck_KeyDown);
            // 
            // button5
            // 
            this.button5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button5.BackColor = System.Drawing.Color.Orange;
            this.button5.FlatAppearance.BorderSize = 0;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(757, 408);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(138, 45);
            this.button5.TabIndex = 104;
            this.button5.Text = "Imprimir";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // ventaIdText
            // 
            this.ventaIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.ventaIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ventaIdText.Location = new System.Drawing.Point(120, 24);
            this.ventaIdText.Name = "ventaIdText";
            this.ventaIdText.Size = new System.Drawing.Size(155, 26);
            this.ventaIdText.TabIndex = 106;
            this.ventaIdText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.devolucionIdText_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 20);
            this.label1.TabIndex = 105;
            this.label1.Text = "Documento";
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(281, 19);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(47, 37);
            this.button7.TabIndex = 107;
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // NcfText
            // 
            this.NcfText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NcfText.Location = new System.Drawing.Point(120, 111);
            this.NcfText.Name = "NcfText";
            this.NcfText.ReadOnly = true;
            this.NcfText.Size = new System.Drawing.Size(263, 26);
            this.NcfText.TabIndex = 109;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(69, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 110;
            this.label4.Text = "NCF";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 69);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 112;
            this.label8.Text = "No. Venta";
            // 
            // numeroVentaText
            // 
            this.numeroVentaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeroVentaText.Location = new System.Drawing.Point(119, 68);
            this.numeroVentaText.Name = "numeroVentaText";
            this.numeroVentaText.ReadOnly = true;
            this.numeroVentaText.Size = new System.Drawing.Size(264, 26);
            this.numeroVentaText.TabIndex = 111;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.numeroVentaText);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.ventaIdText);
            this.groupBox2.Controls.Add(this.NcfText);
            this.groupBox2.Location = new System.Drawing.Point(16, 138);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(408, 146);
            this.groupBox2.TabIndex = 113;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radioButtonVenta);
            this.groupBox3.Controls.Add(this.radioButtonDevolucion);
            this.groupBox3.Location = new System.Drawing.Point(16, 84);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(408, 50);
            this.groupBox3.TabIndex = 127;
            this.groupBox3.TabStop = false;
            // 
            // radioButtonVenta
            // 
            this.radioButtonVenta.AutoSize = true;
            this.radioButtonVenta.Checked = true;
            this.radioButtonVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonVenta.Location = new System.Drawing.Point(97, 17);
            this.radioButtonVenta.Name = "radioButtonVenta";
            this.radioButtonVenta.Size = new System.Drawing.Size(68, 21);
            this.radioButtonVenta.TabIndex = 116;
            this.radioButtonVenta.TabStop = true;
            this.radioButtonVenta.Text = "Venta";
            this.radioButtonVenta.UseVisualStyleBackColor = true;
            this.radioButtonVenta.Leave += new System.EventHandler(this.radioButtonVenta_Leave);
            // 
            // radioButtonDevolucion
            // 
            this.radioButtonDevolucion.AutoSize = true;
            this.radioButtonDevolucion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDevolucion.Location = new System.Drawing.Point(212, 17);
            this.radioButtonDevolucion.Name = "radioButtonDevolucion";
            this.radioButtonDevolucion.Size = new System.Drawing.Size(106, 21);
            this.radioButtonDevolucion.TabIndex = 117;
            this.radioButtonDevolucion.Text = "Devolución";
            this.radioButtonDevolucion.UseVisualStyleBackColor = true;
            this.radioButtonDevolucion.Leave += new System.EventHandler(this.radioButtonDevolucion_Leave);
            // 
            // ventana_nota_credito_cxc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(912, 525);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.activoCheck);
            this.Controls.Add(this.detalleText);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.montoText);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.conceptoComboBox);
            this.Controls.Add(this.fechaText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Name = "ventana_nota_credito_cxc";
            this.Text = "ventana_nota_credito_cxc";
            this.Load += new System.EventHandler(this.ventana_nota_credito_cxc_Load);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.fechaText, 0);
            this.Controls.SetChildIndex(this.conceptoComboBox, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.montoText, 0);
            this.Controls.SetChildIndex(this.label7, 0);
            this.Controls.SetChildIndex(this.detalleText, 0);
            this.Controls.SetChildIndex(this.activoCheck, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.groupBox3, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox notaCreditoIdText;
        private Label label2;
        private Button button4;
        private Label label3;
        private MaskedTextBox fechaText;
        private Label label5;
        private ComboBox conceptoComboBox;
        private TextBox montoText;
        private Label label6;
        private Label label7;
        private TextBox detalleText;
        private CheckBox activoCheck;
        public Button button5;
        private TextBox ventaIdText;
        private Label label1;
        private Button button7;
        private TextBox NcfText;
        private Label label4;
        private Label label8;
        private TextBox numeroVentaText;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private RadioButton radioButtonVenta;
        private RadioButton radioButtonDevolucion;
    }
}