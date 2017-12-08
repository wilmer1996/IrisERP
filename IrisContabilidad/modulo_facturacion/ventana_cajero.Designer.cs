﻿using System.ComponentModel;
using System.Windows.Forms;

namespace IrisContabilidad.modulo_facturacion
{
    partial class ventana_cajero
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ventana_cajero));
            this.activoCheck = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cajeroIdText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.cajaIdText = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.cajaText = new System.Windows.Forms.TextBox();
            this.empleadoText = new System.Windows.Forms.TextBox();
            this.empleadoIdText = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButtonHojaRollo = new System.Windows.Forms.RadioButton();
            this.radioButtonHojaGrande = new System.Windows.Forms.RadioButton();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(16, 494);
            this.panel1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel1.Size = new System.Drawing.Size(707, 66);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.Location = new System.Drawing.Point(519, 6);
            this.button1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // panel2
            // 
            this.panel2.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.panel2.Size = new System.Drawing.Size(739, 25);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.Location = new System.Drawing.Point(260, 6);
            this.button3.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.button3.Click += new System.EventHandler(this.button3_Click_1);
            // 
            // activoCheck
            // 
            this.activoCheck.AutoSize = true;
            this.activoCheck.Checked = true;
            this.activoCheck.CheckState = System.Windows.Forms.CheckState.Checked;
            this.activoCheck.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.activoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.activoCheck.Location = new System.Drawing.Point(152, 433);
            this.activoCheck.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.activoCheck.Name = "activoCheck";
            this.activoCheck.Size = new System.Drawing.Size(79, 24);
            this.activoCheck.TabIndex = 76;
            this.activoCheck.Text = "Active";
            this.activoCheck.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cajeroIdText);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Location = new System.Drawing.Point(16, 33);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(705, 81);
            this.groupBox1.TabIndex = 73;
            this.groupBox1.TabStop = false;
            // 
            // cajeroIdText
            // 
            this.cajeroIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.cajeroIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajeroIdText.Location = new System.Drawing.Point(207, 26);
            this.cajeroIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cajeroIdText.Name = "cajeroIdText";
            this.cajeroIdText.Size = new System.Drawing.Size(205, 30);
            this.cajeroIdText.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(112, 26);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 25);
            this.label2.TabIndex = 9;
            this.label2.Text = "Cashier";
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(421, 20);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 46);
            this.button4.TabIndex = 23;
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cajaIdText
            // 
            this.cajaIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.cajaIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaIdText.Location = new System.Drawing.Point(152, 146);
            this.cajaIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cajaIdText.Name = "cajaIdText";
            this.cajaIdText.Size = new System.Drawing.Size(205, 30);
            this.cajaIdText.TabIndex = 78;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 148);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 25);
            this.label1.TabIndex = 77;
            this.label1.Text = "Cashbox";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(367, 140);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 46);
            this.button5.TabIndex = 79;
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // cajaText
            // 
            this.cajaText.BackColor = System.Drawing.Color.White;
            this.cajaText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cajaText.Location = new System.Drawing.Point(152, 193);
            this.cajaText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cajaText.MaxLength = 100;
            this.cajaText.Name = "cajaText";
            this.cajaText.ReadOnly = true;
            this.cajaText.Size = new System.Drawing.Size(380, 30);
            this.cajaText.TabIndex = 80;
            // 
            // empleadoText
            // 
            this.empleadoText.BackColor = System.Drawing.Color.White;
            this.empleadoText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoText.Location = new System.Drawing.Point(152, 300);
            this.empleadoText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empleadoText.MaxLength = 100;
            this.empleadoText.Name = "empleadoText";
            this.empleadoText.ReadOnly = true;
            this.empleadoText.Size = new System.Drawing.Size(380, 30);
            this.empleadoText.TabIndex = 84;
            // 
            // empleadoIdText
            // 
            this.empleadoIdText.BackColor = System.Drawing.Color.SkyBlue;
            this.empleadoIdText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empleadoIdText.Location = new System.Drawing.Point(152, 254);
            this.empleadoIdText.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.empleadoIdText.Name = "empleadoIdText";
            this.empleadoIdText.Size = new System.Drawing.Size(205, 30);
            this.empleadoIdText.TabIndex = 82;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 255);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 25);
            this.label3.TabIndex = 81;
            this.label3.Text = "Employee";
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(367, 247);
            this.button6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 46);
            this.button6.TabIndex = 83;
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButtonHojaRollo);
            this.groupBox2.Controls.Add(this.radioButtonHojaGrande);
            this.groupBox2.Location = new System.Drawing.Point(152, 340);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(477, 86);
            this.groupBox2.TabIndex = 85;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Type of sale printing";
            // 
            // radioButtonHojaRollo
            // 
            this.radioButtonHojaRollo.AutoSize = true;
            this.radioButtonHojaRollo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHojaRollo.Location = new System.Drawing.Point(259, 38);
            this.radioButtonHojaRollo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHojaRollo.Name = "radioButtonHojaRollo";
            this.radioButtonHojaRollo.Size = new System.Drawing.Size(136, 22);
            this.radioButtonHojaRollo.TabIndex = 1;
            this.radioButtonHojaRollo.Text = "Hoja Rollo(3\")";
            this.radioButtonHojaRollo.UseVisualStyleBackColor = true;
            // 
            // radioButtonHojaGrande
            // 
            this.radioButtonHojaGrande.AutoSize = true;
            this.radioButtonHojaGrande.Checked = true;
            this.radioButtonHojaGrande.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonHojaGrande.Location = new System.Drawing.Point(20, 38);
            this.radioButtonHojaGrande.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.radioButtonHojaGrande.Name = "radioButtonHojaGrande";
            this.radioButtonHojaGrande.Size = new System.Drawing.Size(171, 22);
            this.radioButtonHojaGrande.TabIndex = 0;
            this.radioButtonHojaGrande.TabStop = true;
            this.radioButtonHojaGrande.Text = "Hoja Carta(8.5x11)";
            this.radioButtonHojaGrande.UseVisualStyleBackColor = true;
            // 
            // ventana_cajero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 575);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.empleadoText);
            this.Controls.Add(this.empleadoIdText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.cajaText);
            this.Controls.Add(this.cajaIdText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.activoCheck);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "ventana_cajero";
            this.Text = "ventana_cajero";
            this.Load += new System.EventHandler(this.ventana_cajero_Load);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.activoCheck, 0);
            this.Controls.SetChildIndex(this.button5, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.cajaIdText, 0);
            this.Controls.SetChildIndex(this.cajaText, 0);
            this.Controls.SetChildIndex(this.button6, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.empleadoIdText, 0);
            this.Controls.SetChildIndex(this.empleadoText, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CheckBox activoCheck;
        private GroupBox groupBox1;
        private TextBox cajeroIdText;
        private Label label2;
        private Button button4;
        private TextBox cajaIdText;
        private Label label1;
        private Button button5;
        private TextBox cajaText;
        private TextBox empleadoText;
        private TextBox empleadoIdText;
        private Label label3;
        private Button button6;
        private GroupBox groupBox2;
        private RadioButton radioButtonHojaGrande;
        private RadioButton radioButtonHojaRollo;
    }
}