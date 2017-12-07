﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_cuenta_por_pagar
{
    partial class ventana_busqueda_nota_debito_cxp
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioNCFCompra = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioMonto = new System.Windows.Forms.RadioButton();
            this.radioConcepto = new System.Windows.Forms.RadioButton();
            this.radioSuplidor = new System.Windows.Forms.RadioButton();
            this.radioId = new System.Windows.Forms.RadioButton();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.conceptoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cajerocolumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MontoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 497);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1179, 66);
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(991, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1211, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(496, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioNCFCompra);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.radioMonto);
            this.groupBox1.Controls.Add(this.radioConcepto);
            this.groupBox1.Controls.Add(this.radioSuplidor);
            this.groupBox1.Controls.Add(this.radioId);
            this.groupBox1.Controls.Add(this.nombreText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1171, 107);
            this.groupBox1.TabIndex = 33;
            this.groupBox1.TabStop = false;
            // 
            // radioNCFCompra
            // 
            this.radioNCFCompra.AutoSize = true;
            this.radioNCFCompra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioNCFCompra.Location = new System.Drawing.Point(568, 63);
            this.radioNCFCompra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioNCFCompra.Name = "radioNCFCompra";
            this.radioNCFCompra.Size = new System.Drawing.Size(152, 24);
            this.radioNCFCompra.TabIndex = 26;
            this.radioNCFCompra.Text = "NCF Purchase";
            this.radioNCFCompra.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(753, 68);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "change option(F2)";
            // 
            // radioMonto
            // 
            this.radioMonto.AutoSize = true;
            this.radioMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioMonto.Location = new System.Drawing.Point(456, 63);
            this.radioMonto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioMonto.Name = "radioMonto";
            this.radioMonto.Size = new System.Drawing.Size(93, 24);
            this.radioMonto.TabIndex = 24;
            this.radioMonto.Text = "Amount";
            this.radioMonto.UseVisualStyleBackColor = true;
            // 
            // radioConcepto
            // 
            this.radioConcepto.AutoSize = true;
            this.radioConcepto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioConcepto.Location = new System.Drawing.Point(313, 63);
            this.radioConcepto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioConcepto.Name = "radioConcepto";
            this.radioConcepto.Size = new System.Drawing.Size(99, 24);
            this.radioConcepto.TabIndex = 23;
            this.radioConcepto.Text = "Concept";
            this.radioConcepto.UseVisualStyleBackColor = true;
            // 
            // radioSuplidor
            // 
            this.radioSuplidor.AutoSize = true;
            this.radioSuplidor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSuplidor.Location = new System.Drawing.Point(183, 63);
            this.radioSuplidor.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioSuplidor.Name = "radioSuplidor";
            this.radioSuplidor.Size = new System.Drawing.Size(99, 24);
            this.radioSuplidor.TabIndex = 22;
            this.radioSuplidor.Text = "Supplier";
            this.radioSuplidor.UseVisualStyleBackColor = true;
            // 
            // radioId
            // 
            this.radioId.AutoSize = true;
            this.radioId.Checked = true;
            this.radioId.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioId.Location = new System.Drawing.Point(107, 63);
            this.radioId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioId.Name = "radioId";
            this.radioId.Size = new System.Drawing.Size(49, 24);
            this.radioId.TabIndex = 21;
            this.radioId.TabStop = true;
            this.radioId.Text = "ID";
            this.radioId.UseVisualStyleBackColor = true;
            // 
            // nombreText
            // 
            this.nombreText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombreText.Location = new System.Drawing.Point(108, 23);
            this.nombreText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nombreText.Name = "nombreText";
            this.nombreText.Size = new System.Drawing.Size(527, 30);
            this.nombreText.TabIndex = 20;
            this.nombreText.KeyDown += new System.Windows.Forms.KeyEventHandler(this.nombreText_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 27);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 19;
            this.label3.Text = "Search";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.codigoColumn,
            this.FechaColumn,
            this.conceptoColumn,
            this.Cajerocolumn,
            this.Column1,
            this.Column2,
            this.MontoColumn});
            this.dataGridView1.Location = new System.Drawing.Point(20, 166);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1171, 314);
            this.dataGridView1.TabIndex = 32;
            // 
            // codigoColumn
            // 
            this.codigoColumn.FillWeight = 50F;
            this.codigoColumn.HeaderText = "ID";
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.ReadOnly = true;
            // 
            // FechaColumn
            // 
            this.FechaColumn.HeaderText = "Date";
            this.FechaColumn.Name = "FechaColumn";
            this.FechaColumn.ReadOnly = true;
            // 
            // conceptoColumn
            // 
            this.conceptoColumn.HeaderText = "Concept";
            this.conceptoColumn.Name = "conceptoColumn";
            this.conceptoColumn.ReadOnly = true;
            // 
            // Cajerocolumn
            // 
            this.Cajerocolumn.HeaderText = "Supplier";
            this.Cajerocolumn.Name = "Cajerocolumn";
            this.Cajerocolumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Purchase";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "NCF";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // MontoColumn
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopRight;
            this.MontoColumn.DefaultCellStyle = dataGridViewCellStyle1;
            this.MontoColumn.FillWeight = 60F;
            this.MontoColumn.HeaderText = "Amount";
            this.MontoColumn.Name = "MontoColumn";
            this.MontoColumn.ReadOnly = true;
            // 
            // ventana_busqueda_nota_debito_cxp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1211, 578);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_busqueda_nota_debito_cxp";
            this.Text = "ventana_busqueda_nota_debito_cxc";
            this.Load += new System.EventHandler(this.ventana_busqueda_nota_debito_cxc_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ventana_busqueda_nota_debito_cxc_KeyDown);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private RadioButton radioNCFCompra;
        private Label label1;
        private RadioButton radioMonto;
        private RadioButton radioConcepto;
        private RadioButton radioSuplidor;
        private RadioButton radioId;
        private TextBox nombreText;
        private Label label3;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn codigoColumn;
        private DataGridViewTextBoxColumn FechaColumn;
        private DataGridViewTextBoxColumn conceptoColumn;
        private DataGridViewTextBoxColumn Cajerocolumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn MontoColumn;
    }
}