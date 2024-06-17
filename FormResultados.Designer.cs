namespace Guia12_1_Ej2ControlPaso
{
    partial class FormResultados
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.btCerrarModal = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbResultados);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(260, 308);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Resultados";
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(7, 20);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(247, 277);
            this.lbResultados.TabIndex = 0;
            // 
            // btCerrarModal
            // 
            this.btCerrarModal.Location = new System.Drawing.Point(324, 144);
            this.btCerrarModal.Name = "btCerrarModal";
            this.btCerrarModal.Size = new System.Drawing.Size(75, 23);
            this.btCerrarModal.TabIndex = 1;
            this.btCerrarModal.Text = "Cerrar";
            this.btCerrarModal.UseVisualStyleBackColor = true;
            this.btCerrarModal.Click += new System.EventHandler(this.btCerrarModal_Click);
            // 
            // FormResultados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 325);
            this.Controls.Add(this.btCerrarModal);
            this.Controls.Add(this.groupBox1);
            this.Name = "FormResultados";
            this.Text = "Estadistica";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.GroupBox groupBox1;
        public System.Windows.Forms.ListBox lbResultados;
        public System.Windows.Forms.Button btCerrarModal;
    }
}