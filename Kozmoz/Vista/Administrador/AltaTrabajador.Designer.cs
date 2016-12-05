namespace Vista.Administrador
{
    partial class AltaTrabajador
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbempresa = new System.Windows.Forms.ComboBox();
            this.cmbdepartamento = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.txttelefono = new System.Windows.Forms.TextBox();
            this.txtnoempleado = new System.Windows.Forms.TextBox();
            this.txtcargo = new System.Windows.Forms.TextBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnagregar = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbgenero = new System.Windows.Forms.ComboBox();
            this.txtusuario = new System.Windows.Forms.TextBox();
            this.txtcontraseña = new System.Windows.Forms.TextBox();
            this.cmbestatus = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.txtdirecion = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(31, 35);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(328, 609);
            this.treeView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(427, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Empresa";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(753, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Departamento";
            // 
            // cmbempresa
            // 
            this.cmbempresa.FormattingEnabled = true;
            this.cmbempresa.Location = new System.Drawing.Point(430, 73);
            this.cmbempresa.Name = "cmbempresa";
            this.cmbempresa.Size = new System.Drawing.Size(235, 21);
            this.cmbempresa.TabIndex = 3;
            this.cmbempresa.TextChanged += new System.EventHandler(this.cmbempresa_TextChanged);
            // 
            // cmbdepartamento
            // 
            this.cmbdepartamento.FormattingEnabled = true;
            this.cmbdepartamento.Location = new System.Drawing.Point(756, 73);
            this.cmbdepartamento.Name = "cmbdepartamento";
            this.cmbdepartamento.Size = new System.Drawing.Size(255, 21);
            this.cmbdepartamento.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(427, 154);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(427, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Edad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(584, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Genero";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(729, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Telefono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(427, 313);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "No Epleado";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(729, 313);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Cargo";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(433, 440);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 13);
            this.label9.TabIndex = 11;
            this.label9.Text = "Imagen";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(430, 179);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(286, 20);
            this.txtnombre.TabIndex = 12;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(430, 253);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(76, 20);
            this.txtedad.TabIndex = 13;
            // 
            // txttelefono
            // 
            this.txttelefono.Location = new System.Drawing.Point(732, 253);
            this.txttelefono.Name = "txttelefono";
            this.txttelefono.Size = new System.Drawing.Size(207, 20);
            this.txttelefono.TabIndex = 14;
            // 
            // txtnoempleado
            // 
            this.txtnoempleado.Location = new System.Drawing.Point(430, 343);
            this.txtnoempleado.Name = "txtnoempleado";
            this.txtnoempleado.Size = new System.Drawing.Size(143, 20);
            this.txtnoempleado.TabIndex = 15;
            // 
            // txtcargo
            // 
            this.txtcargo.Location = new System.Drawing.Point(732, 343);
            this.txtcargo.Name = "txtcargo";
            this.txtcargo.Size = new System.Drawing.Size(172, 20);
            this.txtcargo.TabIndex = 16;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(435, 471);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(235, 20);
            this.txtimagen.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(701, 468);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 23);
            this.button1.TabIndex = 18;
            this.button1.Text = "Examinar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnagregar
            // 
            this.btnagregar.Location = new System.Drawing.Point(1004, 621);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(127, 23);
            this.btnagregar.TabIndex = 19;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = true;
            this.btnagregar.Click += new System.EventHandler(this.btnagregar_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(432, 520);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 20;
            this.label10.Text = "Usuario";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(729, 520);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 21;
            this.label11.Text = "Contraseña";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(963, 520);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 22;
            this.label12.Text = "Estatus";
            // 
            // cmbgenero
            // 
            this.cmbgenero.FormattingEnabled = true;
            this.cmbgenero.Items.AddRange(new object[] {
            "Maxculino",
            "Femenino"});
            this.cmbgenero.Location = new System.Drawing.Point(587, 251);
            this.cmbgenero.Name = "cmbgenero";
            this.cmbgenero.Size = new System.Drawing.Size(78, 21);
            this.cmbgenero.TabIndex = 23;
            // 
            // txtusuario
            // 
            this.txtusuario.Location = new System.Drawing.Point(430, 556);
            this.txtusuario.Name = "txtusuario";
            this.txtusuario.Size = new System.Drawing.Size(224, 20);
            this.txtusuario.TabIndex = 24;
            // 
            // txtcontraseña
            // 
            this.txtcontraseña.Location = new System.Drawing.Point(732, 556);
            this.txtcontraseña.Name = "txtcontraseña";
            this.txtcontraseña.Size = new System.Drawing.Size(172, 20);
            this.txtcontraseña.TabIndex = 25;
            // 
            // cmbestatus
            // 
            this.cmbestatus.FormattingEnabled = true;
            this.cmbestatus.Items.AddRange(new object[] {
            "Activo",
            "No Activo"});
            this.cmbestatus.Location = new System.Drawing.Point(966, 555);
            this.cmbestatus.Name = "cmbestatus";
            this.cmbestatus.Size = new System.Drawing.Size(121, 21);
            this.cmbestatus.TabIndex = 26;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(433, 394);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 13);
            this.label13.TabIndex = 27;
            this.label13.Text = "Direcion";
            // 
            // txtdirecion
            // 
            this.txtdirecion.Location = new System.Drawing.Point(435, 411);
            this.txtdirecion.Name = "txtdirecion";
            this.txtdirecion.Size = new System.Drawing.Size(355, 20);
            this.txtdirecion.TabIndex = 28;
            // 
            // AltaTrabajador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 673);
            this.Controls.Add(this.txtdirecion);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.cmbestatus);
            this.Controls.Add(this.txtcontraseña);
            this.Controls.Add(this.txtusuario);
            this.Controls.Add(this.cmbgenero);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.txtcargo);
            this.Controls.Add(this.txtnoempleado);
            this.Controls.Add(this.txttelefono);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbdepartamento);
            this.Controls.Add(this.cmbempresa);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "AltaTrabajador";
            this.Text = "AltaTrabajador";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaTrabajador_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbempresa;
        private System.Windows.Forms.ComboBox cmbdepartamento;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.TextBox txttelefono;
        private System.Windows.Forms.TextBox txtnoempleado;
        private System.Windows.Forms.TextBox txtcargo;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnagregar;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbgenero;
        private System.Windows.Forms.TextBox txtusuario;
        private System.Windows.Forms.TextBox txtcontraseña;
        private System.Windows.Forms.ComboBox cmbestatus;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtdirecion;
    }
}