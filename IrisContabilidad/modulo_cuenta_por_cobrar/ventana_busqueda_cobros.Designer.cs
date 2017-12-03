﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_cuenta_por_cobrar
{
    partial class ventana_busqueda_cobros
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButtonCliente = new System.Windows.Forms.RadioButton();
            this.radioButtonDetalle = new System.Windows.Forms.RadioButton();
            this.radioButtonEmpleado = new System.Windows.Forms.RadioButton();
            this.radioButtonFecha = new System.Windows.Forms.RadioButton();
            this.radioButtonID = new System.Windows.Forms.RadioButton();
            this.nombreText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.codigoColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 683);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(1203, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(1015, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(1235, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(508, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButtonCliente);
            this.groupBox1.Controls.Add(this.radioButtonDetalle);
            this.groupBox1.Controls.Add(this.radioButtonEmpleado);
            this.groupBox1.Controls.Add(this.radioButtonFecha);
            this.groupBox1.Controls.Add(this.radioButtonID);
            this.groupBox1.Controls.Add(this.nombreText);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(21, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1197, 113);
            this.groupBox1.TabIndex = 31;
            this.groupBox1.TabStop = false;
            // 
            // radioButtonCliente
            // 
            this.radioButtonCliente.AutoSize = true;
            this.radioButtonCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonCliente.Location = new System.Drawing.Point(533, 63);
            this.radioButtonCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonCliente.Name = "radioButtonCliente";
            this.radioButtonCliente.Size = new System.Drawing.Size(111, 24);
            this.radioButtonCliente.TabIndex = 25;
            this.radioButtonCliente.Text = "Customer";
            this.radioButtonCliente.UseVisualStyleBackColor = true;
            // 
            // radioButtonDetalle
            // 
            this.radioButtonDetalle.AutoSize = true;
            this.radioButtonDetalle.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonDetalle.Location = new System.Drawing.Point(673, 63);
            this.radioButtonDetalle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonDetalle.Name = "radioButtonDetalle";
            this.radioButtonDetalle.Size = new System.Drawing.Size(80, 24);
            this.radioButtonDetalle.TabIndex = 24;
            this.radioButtonDetalle.Text = "Detail";
            this.radioButtonDetalle.UseVisualStyleBackColor = true;
            // 
            // radioButtonEmpleado
            // 
            this.radioButtonEmpleado.AutoSize = true;
            this.radioButtonEmpleado.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonEmpleado.Location = new System.Drawing.Point(368, 63);
            this.radioButtonEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonEmpleado.Name = "radioButtonEmpleado";
            this.radioButtonEmpleado.Size = new System.Drawing.Size(111, 24);
            this.radioButtonEmpleado.TabIndex = 23;
            this.radioButtonEmpleado.Text = "Employee";
            this.radioButtonEmpleado.UseVisualStyleBackColor = true;
            // 
            // radioButtonFecha
            // 
            this.radioButtonFecha.AutoSize = true;
            this.radioButtonFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonFecha.Location = new System.Drawing.Point(224, 63);
            this.radioButtonFecha.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonFecha.Name = "radioButtonFecha";
            this.radioButtonFecha.Size = new System.Drawing.Size(70, 24);
            this.radioButtonFecha.TabIndex = 22;
            this.radioButtonFecha.Text = "Date";
            this.radioButtonFecha.UseVisualStyleBackColor = true;
            // 
            // radioButtonID
            // 
            this.radioButtonID.AutoSize = true;
            this.radioButtonID.Checked = true;
            this.radioButtonID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonID.Location = new System.Drawing.Point(108, 63);
            this.radioButtonID.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonID.Name = "radioButtonID";
            this.radioButtonID.Size = new System.Drawing.Size(49, 24);
            this.radioButtonID.TabIndex = 21;
            this.radioButtonID.TabStop = true;
            this.radioButtonID.Text = "ID";
            this.radioButtonID.UseVisualStyleBackColor = true;
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
            this.Column1,
            this.Column3,
            this.Column2});
            this.dataGridView1.Location = new System.Drawing.Point(21, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1197, 522);
            this.dataGridView1.TabIndex = 30;
            // 
            // codigoColumn
            // 
            this.codigoColumn.FillWeight = 30F;
            this.codigoColumn.HeaderText = "Id";
            this.codigoColumn.Name = "codigoColumn";
            this.codigoColumn.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.FillWeight = 50F;
            this.Column1.HeaderText = "Date";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Customer";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Employee";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // ventana_busqueda_cobros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 764);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_busqueda_cobros";
            this.Text = "ventana_busqueda_cobros";
            this.Load += new System.EventHandler(this.ventana_busqueda_cobros_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ventana_busqueda_cobros_KeyDown);
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
        private RadioButton radioButtonDetalle;
        private RadioButton radioButtonEmpleado;
        private RadioButton radioButtonFecha;
        private RadioButton radioButtonID;
        private TextBox nombreText;
        private Label label3;
        private DataGridView dataGridView1;
        private RadioButton radioButtonCliente;
        private DataGridViewTextBoxColumn codigoColumn;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column2;
    }
}