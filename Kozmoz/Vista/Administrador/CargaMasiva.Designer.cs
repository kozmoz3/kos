namespace Vista.Administrador
{
    partial class CargaMasiva
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
            this.btnseleccionar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtruta = new System.Windows.Forms.TextBox();
            this.btncargar = new System.Windows.Forms.Button();
            this.btnvalidar = new System.Windows.Forms.Button();
            this.txthoja = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnseleccionar
            // 
            this.btnseleccionar.Location = new System.Drawing.Point(308, 73);
            this.btnseleccionar.Name = "btnseleccionar";
            this.btnseleccionar.Size = new System.Drawing.Size(125, 28);
            this.btnseleccionar.TabIndex = 0;
            this.btnseleccionar.Text = "Examinar";
            this.btnseleccionar.UseVisualStyleBackColor = true;
            this.btnseleccionar.Click += new System.EventHandler(this.btnseleccionar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "SELECCIONÉ EL ARCHIVO";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtruta
            // 
            this.txtruta.Location = new System.Drawing.Point(29, 78);
            this.txtruta.Name = "txtruta";
            this.txtruta.Size = new System.Drawing.Size(273, 20);
            this.txtruta.TabIndex = 3;
            // 
            // btncargar
            // 
            this.btncargar.Location = new System.Drawing.Point(308, 162);
            this.btncargar.Name = "btncargar";
            this.btncargar.Size = new System.Drawing.Size(125, 28);
            this.btncargar.TabIndex = 4;
            this.btncargar.Text = "Cargar Archivo";
            this.btncargar.UseVisualStyleBackColor = true;
            // 
            // btnvalidar
            // 
            this.btnvalidar.Location = new System.Drawing.Point(308, 124);
            this.btnvalidar.Name = "btnvalidar";
            this.btnvalidar.Size = new System.Drawing.Size(125, 23);
            this.btnvalidar.TabIndex = 5;
            this.btnvalidar.Text = "Validar";
            this.btnvalidar.UseVisualStyleBackColor = true;
            this.btnvalidar.Click += new System.EventHandler(this.btnvalidar_Click);
            // 
            // txthoja
            // 
            this.txthoja.Location = new System.Drawing.Point(29, 124);
            this.txthoja.Name = "txthoja";
            this.txthoja.Size = new System.Drawing.Size(273, 20);
            this.txthoja.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "INGRESE EL NOMBRE DE LA HOJA";
            // 
            // CargaMasiva
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(445, 202);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txthoja);
            this.Controls.Add(this.btnvalidar);
            this.Controls.Add(this.btncargar);
            this.Controls.Add(this.txtruta);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnseleccionar);
            this.Name = "CargaMasiva";
            this.Text = "CargaMasiva";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnseleccionar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtruta;
        private System.Windows.Forms.Button btncargar;
        private System.Windows.Forms.Button btnvalidar;
        private System.Windows.Forms.TextBox txthoja;
        private System.Windows.Forms.Label label2;
    }
}