namespace Guia12_1_Ej2ControlPaso
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.tbAñoFab = new System.Windows.Forms.TextBox();
            this.tbPatente = new System.Windows.Forms.TextBox();
            this.cbElectrico = new System.Windows.Forms.CheckBox();
            this.btEstadistica = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patente";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Vehiculo";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Modelo (Año de Fabricación)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // cbTipoVehiculo
            // 
            this.cbTipoVehiculo.FormattingEnabled = true;
            this.cbTipoVehiculo.Items.AddRange(new object[] {
            "Automovil",
            "Motocicleta",
            "Camioneta",
            "Camión"});
            this.cbTipoVehiculo.Location = new System.Drawing.Point(189, 65);
            this.cbTipoVehiculo.Name = "cbTipoVehiculo";
            this.cbTipoVehiculo.Size = new System.Drawing.Size(121, 21);
            this.cbTipoVehiculo.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btRegistrar);
            this.groupBox1.Controls.Add(this.tbAñoFab);
            this.groupBox1.Controls.Add(this.tbPatente);
            this.groupBox1.Controls.Add(this.cbElectrico);
            this.groupBox1.Location = new System.Drawing.Point(12, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(415, 318);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // btRegistrar
            // 
            this.btRegistrar.Location = new System.Drawing.Point(177, 223);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(121, 54);
            this.btRegistrar.TabIndex = 3;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // tbAñoFab
            // 
            this.tbAñoFab.Location = new System.Drawing.Point(177, 96);
            this.tbAñoFab.Name = "tbAñoFab";
            this.tbAñoFab.Size = new System.Drawing.Size(121, 20);
            this.tbAñoFab.TabIndex = 2;
            this.tbAñoFab.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // tbPatente
            // 
            this.tbPatente.Location = new System.Drawing.Point(177, 27);
            this.tbPatente.Name = "tbPatente";
            this.tbPatente.Size = new System.Drawing.Size(121, 20);
            this.tbPatente.TabIndex = 1;
            // 
            // cbElectrico
            // 
            this.cbElectrico.AutoSize = true;
            this.cbElectrico.Location = new System.Drawing.Point(177, 135);
            this.cbElectrico.Name = "cbElectrico";
            this.cbElectrico.Size = new System.Drawing.Size(93, 17);
            this.cbElectrico.TabIndex = 0;
            this.cbElectrico.Text = "¿Es eléctirco?";
            this.cbElectrico.UseVisualStyleBackColor = true;
            this.cbElectrico.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btEstadistica
            // 
            this.btEstadistica.Location = new System.Drawing.Point(483, 137);
            this.btEstadistica.Name = "btEstadistica";
            this.btEstadistica.Size = new System.Drawing.Size(101, 58);
            this.btEstadistica.TabIndex = 5;
            this.btEstadistica.Text = "Ver Estadistica";
            this.btEstadistica.UseVisualStyleBackColor = true;
            this.btEstadistica.Click += new System.EventHandler(this.btEstadistica_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 329);
            this.Controls.Add(this.btEstadistica);
            this.Controls.Add(this.cbTipoVehiculo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btEstadistica;
        public System.Windows.Forms.CheckBox cbElectrico;
        public System.Windows.Forms.TextBox tbPatente;
        public System.Windows.Forms.ComboBox cbTipoVehiculo;
        public System.Windows.Forms.TextBox tbAñoFab;
    }
}

