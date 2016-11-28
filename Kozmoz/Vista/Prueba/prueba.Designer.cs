namespace Vista.Prueba
{
    partial class prueba
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
            this.datos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.datos)).BeginInit();
            this.SuspendLayout();
            // 
            // datos
            // 
            this.datos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datos.Location = new System.Drawing.Point(141, 79);
            this.datos.Name = "datos";
            this.datos.Size = new System.Drawing.Size(240, 150);
            this.datos.TabIndex = 1;
            // 
            // prueba
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 308);
            this.Controls.Add(this.datos);
            this.Name = "prueba";
            this.Text = "prueba";
            this.Load += new System.EventHandler(this.prueba_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView datos;
    }
}