namespace WindowsForms
{
    partial class NewSesion
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dateFecha = new System.Windows.Forms.DateTimePicker();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.richDescripcion = new System.Windows.Forms.RichTextBox();
            this.comboLabs = new System.Windows.Forms.ComboBox();
            this.numMuestras = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.rbDigito = new System.Windows.Forms.RadioButton();
            this.rbLetra = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestras)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(326, 172);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(106, 28);
            this.btnGuardar.TabIndex = 0;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Descripcion:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "# Muestras: *";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 26);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Fecha Inicio: *";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(102, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Laboratorio origen: *";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 107);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Protocolo: ";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // dateFecha
            // 
            this.dateFecha.Location = new System.Drawing.Point(118, 24);
            this.dateFecha.Name = "dateFecha";
            this.dateFecha.Size = new System.Drawing.Size(134, 20);
            this.dateFecha.TabIndex = 6;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(76, 105);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(61, 17);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Arabica";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbLetra);
            this.groupBox1.Controls.Add(this.rbDigito);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.numMuestras);
            this.groupBox1.Controls.Add(this.comboLabs);
            this.groupBox1.Controls.Add(this.dateFecha);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(11, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(273, 170);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Obligatorios";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richDescripcion);
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(295, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(181, 141);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Opcionales";
            // 
            // richDescripcion
            // 
            this.richDescripcion.Location = new System.Drawing.Point(76, 22);
            this.richDescripcion.Name = "richDescripcion";
            this.richDescripcion.Size = new System.Drawing.Size(99, 67);
            this.richDescripcion.TabIndex = 8;
            this.richDescripcion.Text = "";
            // 
            // comboLabs
            // 
            this.comboLabs.FormattingEnabled = true;
            this.comboLabs.Location = new System.Drawing.Point(116, 101);
            this.comboLabs.Name = "comboLabs";
            this.comboLabs.Size = new System.Drawing.Size(136, 21);
            this.comboLabs.TabIndex = 8;
            // 
            // numMuestras
            // 
            this.numMuestras.Location = new System.Drawing.Point(116, 65);
            this.numMuestras.Maximum = new decimal(new int[] {
            15,
            0,
            0,
            0});
            this.numMuestras.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numMuestras.Name = "numMuestras";
            this.numMuestras.Size = new System.Drawing.Size(120, 20);
            this.numMuestras.TabIndex = 10;
            this.numMuestras.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(36, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Identificador: *";
            // 
            // rbDigito
            // 
            this.rbDigito.AutoSize = true;
            this.rbDigito.Checked = true;
            this.rbDigito.Location = new System.Drawing.Point(118, 143);
            this.rbDigito.Name = "rbDigito";
            this.rbDigito.Size = new System.Drawing.Size(57, 17);
            this.rbDigito.TabIndex = 12;
            this.rbDigito.TabStop = true;
            this.rbDigito.Text = "Digitos";
            this.rbDigito.UseVisualStyleBackColor = true;
            // 
            // rbLetra
            // 
            this.rbLetra.AutoSize = true;
            this.rbLetra.Location = new System.Drawing.Point(195, 143);
            this.rbLetra.Name = "rbLetra";
            this.rbLetra.Size = new System.Drawing.Size(54, 17);
            this.rbLetra.TabIndex = 13;
            this.rbLetra.Text = "Letras";
            this.rbLetra.UseVisualStyleBackColor = true;
            // 
            // NewSesion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 212);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnGuardar);
            this.Name = "NewSesion";
            this.Text = "NUEVA SESION DE CATADO";
            this.Load += new System.EventHandler(this.NewSesion_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numMuestras)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dateFecha;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboLabs;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox richDescripcion;
        private System.Windows.Forms.NumericUpDown numMuestras;
        private System.Windows.Forms.RadioButton rbLetra;
        private System.Windows.Forms.RadioButton rbDigito;
        private System.Windows.Forms.Label label6;
    }
}