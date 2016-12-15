namespace Vista.Administrador
{
    partial class AltaDepartamento
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
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cmbempresa = new System.Windows.Forms.ComboBox();
            this.txtnum = new System.Windows.Forms.TextBox();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtnombrecorto = new System.Windows.Forms.TextBox();
            this.txtimagen = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnregistrar = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txttelefono2 = new System.Windows.Forms.TextBox();
            this.txttelefono1 = new System.Windows.Forms.TextBox();
            this.txtcorreo2 = new System.Windows.Forms.TextBox();
            this.txtcorreo1 = new System.Windows.Forms.TextBox();
            this.txtencargado1 = new System.Windows.Forms.TextBox();
            this.txtencargado = new System.Windows.Forms.TextBox();
            this.txtcp = new System.Windows.Forms.TextBox();
            this.txtmunicipio = new System.Windows.Forms.TextBox();
            this.txtcolonia = new System.Windows.Forms.TextBox();
            this.txtcalle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtciudad = new System.Windows.Forms.TextBox();
            this.cbciudad = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.btnactualizar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(45, 28);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(218, 542);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(336, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "EMPRESA";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(391, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "DEPARTAMENTO";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(336, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "CLAVE DE DEPARTAMENTO";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(431, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "SIGLAS";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(427, 205);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "IMAGEN";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // cmbempresa
            // 
            this.cmbempresa.FormattingEnabled = true;
            this.cmbempresa.Location = new System.Drawing.Point(339, 57);
            this.cmbempresa.Name = "cmbempresa";
            this.cmbempresa.Size = new System.Drawing.Size(339, 21);
            this.cmbempresa.TabIndex = 6;
            this.cmbempresa.TextChanged += new System.EventHandler(this.cmbempresa_TextChanged);
            // 
            // txtnum
            // 
            this.txtnum.Location = new System.Drawing.Point(512, 93);
            this.txtnum.Name = "txtnum";
            this.txtnum.Size = new System.Drawing.Size(217, 20);
            this.txtnum.TabIndex = 7;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(512, 127);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(217, 20);
            this.txtnombre.TabIndex = 8;
            // 
            // txtnombrecorto
            // 
            this.txtnombrecorto.Location = new System.Drawing.Point(512, 163);
            this.txtnombrecorto.Name = "txtnombrecorto";
            this.txtnombrecorto.Size = new System.Drawing.Size(217, 20);
            this.txtnombrecorto.TabIndex = 9;
            // 
            // txtimagen
            // 
            this.txtimagen.Location = new System.Drawing.Point(512, 198);
            this.txtimagen.Name = "txtimagen";
            this.txtimagen.Size = new System.Drawing.Size(217, 20);
            this.txtimagen.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(756, 195);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(130, 23);
            this.button1.TabIndex = 11;
            this.button1.Text = "EXAMINAR";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnregistrar
            // 
            this.btnregistrar.Location = new System.Drawing.Point(779, 588);
            this.btnregistrar.Name = "btnregistrar";
            this.btnregistrar.Size = new System.Drawing.Size(153, 23);
            this.btnregistrar.TabIndex = 12;
            this.btnregistrar.Text = "REGISTRAR";
            this.btnregistrar.UseVisualStyleBackColor = true;
            this.btnregistrar.Click += new System.EventHandler(this.btnregistrar_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(923, 466);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 70;
            this.label13.Text = "TELEFONO 2";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(673, 466);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 13);
            this.label11.TabIndex = 69;
            this.label11.Text = "CORREO2";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(673, 396);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 13);
            this.label10.TabIndex = 68;
            this.label10.Text = "CORREO 1";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(311, 466);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 67;
            this.label9.Text = "ENCARGADO 2";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(711, 257);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 66;
            this.label7.Text = "C.P";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(789, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "DELEGACION / MUNICIPIO";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(510, 257);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(54, 13);
            this.label14.TabIndex = 64;
            this.label14.Text = "COLONIA";
            // 
            // txttelefono2
            // 
            this.txttelefono2.Location = new System.Drawing.Point(926, 482);
            this.txttelefono2.Name = "txttelefono2";
            this.txttelefono2.Size = new System.Drawing.Size(170, 20);
            this.txttelefono2.TabIndex = 63;
            // 
            // txttelefono1
            // 
            this.txttelefono1.Location = new System.Drawing.Point(926, 422);
            this.txttelefono1.Name = "txttelefono1";
            this.txttelefono1.Size = new System.Drawing.Size(170, 20);
            this.txttelefono1.TabIndex = 62;
            // 
            // txtcorreo2
            // 
            this.txtcorreo2.Location = new System.Drawing.Point(676, 482);
            this.txtcorreo2.Name = "txtcorreo2";
            this.txtcorreo2.Size = new System.Drawing.Size(210, 20);
            this.txtcorreo2.TabIndex = 61;
            // 
            // txtcorreo1
            // 
            this.txtcorreo1.Location = new System.Drawing.Point(676, 422);
            this.txtcorreo1.Name = "txtcorreo1";
            this.txtcorreo1.Size = new System.Drawing.Size(210, 20);
            this.txtcorreo1.TabIndex = 60;
            // 
            // txtencargado1
            // 
            this.txtencargado1.Location = new System.Drawing.Point(318, 482);
            this.txtencargado1.Name = "txtencargado1";
            this.txtencargado1.Size = new System.Drawing.Size(316, 20);
            this.txtencargado1.TabIndex = 59;
            // 
            // txtencargado
            // 
            this.txtencargado.Location = new System.Drawing.Point(314, 422);
            this.txtencargado.Name = "txtencargado";
            this.txtencargado.Size = new System.Drawing.Size(320, 20);
            this.txtencargado.TabIndex = 58;
            // 
            // txtcp
            // 
            this.txtcp.Location = new System.Drawing.Point(714, 290);
            this.txtcp.Name = "txtcp";
            this.txtcp.Size = new System.Drawing.Size(53, 20);
            this.txtcp.TabIndex = 57;
            // 
            // txtmunicipio
            // 
            this.txtmunicipio.Location = new System.Drawing.Point(792, 290);
            this.txtmunicipio.Name = "txtmunicipio";
            this.txtmunicipio.Size = new System.Drawing.Size(170, 20);
            this.txtmunicipio.TabIndex = 56;
            // 
            // txtcolonia
            // 
            this.txtcolonia.Location = new System.Drawing.Point(513, 290);
            this.txtcolonia.Name = "txtcolonia";
            this.txtcolonia.Size = new System.Drawing.Size(170, 20);
            this.txtcolonia.TabIndex = 55;
            // 
            // txtcalle
            // 
            this.txtcalle.Location = new System.Drawing.Point(318, 289);
            this.txtcalle.Name = "txtcalle";
            this.txtcalle.Size = new System.Drawing.Size(170, 20);
            this.txtcalle.TabIndex = 54;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(315, 257);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 71;
            this.label16.Text = "CALLE";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(314, 333);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(95, 20);
            this.label15.TabIndex = 72;
            this.label15.Text = "CONTACTO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(315, 396);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(84, 13);
            this.label8.TabIndex = 73;
            this.label8.Text = "ENCARGADO 1";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(923, 396);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 13);
            this.label12.TabIndex = 74;
            this.label12.Text = "TELEFONO";
            // 
            // txtciudad
            // 
            this.txtciudad.Location = new System.Drawing.Point(983, 325);
            this.txtciudad.Name = "txtciudad";
            this.txtciudad.Size = new System.Drawing.Size(100, 20);
            this.txtciudad.TabIndex = 77;
            // 
            // cbciudad
            // 
            this.cbciudad.FormattingEnabled = true;
            this.cbciudad.Location = new System.Drawing.Point(983, 289);
            this.cbciudad.Name = "cbciudad";
            this.cbciudad.Size = new System.Drawing.Size(146, 21);
            this.cbciudad.TabIndex = 76;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(980, 257);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(48, 13);
            this.label17.TabIndex = 75;
            this.label17.Text = "CIUDAD";
            // 
            // btnactualizar
            // 
            this.btnactualizar.Location = new System.Drawing.Point(963, 588);
            this.btnactualizar.Name = "btnactualizar";
            this.btnactualizar.Size = new System.Drawing.Size(166, 23);
            this.btnactualizar.TabIndex = 78;
            this.btnactualizar.Text = "ACTUALIZAR DEPARTAMENTO";
            this.btnactualizar.UseVisualStyleBackColor = true;
            this.btnactualizar.Click += new System.EventHandler(this.btnactualizar_Click);
            // 
            // AltaDepartamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1162, 623);
            this.Controls.Add(this.btnactualizar);
            this.Controls.Add(this.txtciudad);
            this.Controls.Add(this.cbciudad);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txttelefono2);
            this.Controls.Add(this.txttelefono1);
            this.Controls.Add(this.txtcorreo2);
            this.Controls.Add(this.txtcorreo1);
            this.Controls.Add(this.txtencargado1);
            this.Controls.Add(this.txtencargado);
            this.Controls.Add(this.txtcp);
            this.Controls.Add(this.txtmunicipio);
            this.Controls.Add(this.txtcolonia);
            this.Controls.Add(this.txtcalle);
            this.Controls.Add(this.btnregistrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtimagen);
            this.Controls.Add(this.txtnombrecorto);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txtnum);
            this.Controls.Add(this.cmbempresa);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.treeView1);
            this.Name = "AltaDepartamento";
            this.Text = "ALTA DE DEPAARTAMENTOS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AltaDepartamento_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbempresa;
        private System.Windows.Forms.TextBox txtnum;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtnombrecorto;
        private System.Windows.Forms.TextBox txtimagen;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnregistrar;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txttelefono2;
        private System.Windows.Forms.TextBox txttelefono1;
        private System.Windows.Forms.TextBox txtcorreo2;
        private System.Windows.Forms.TextBox txtcorreo1;
        private System.Windows.Forms.TextBox txtencargado1;
        private System.Windows.Forms.TextBox txtencargado;
        private System.Windows.Forms.TextBox txtcp;
        private System.Windows.Forms.TextBox txtmunicipio;
        private System.Windows.Forms.TextBox txtcolonia;
        private System.Windows.Forms.TextBox txtcalle;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtciudad;
        private System.Windows.Forms.ComboBox cbciudad;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnactualizar;
    }
}