using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista.Administrador
{
    public partial class MenuAdministrador : Form
    {
        public MenuAdministrador()
        {
            InitializeComponent();
        }
        public MenuAdministrador(String usuario)
        {
            InitializeComponent();
            lbusuario.Text = usuario;
        }

        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void direccionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void aLTADEEMPRESAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaEmpresa empresa = new AltaEmpresa(lbusuario.Text);
            empresa.MdiParent = this;
            empresa.Show();
        }

        private void cARGADEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDepartamento departamento = new AltaDepartamento(lbusuario.Text);
            departamento.MdiParent = this;
            departamento.Show();
        }

        private void aLTADETRABAJADORESToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTrabajador trabajador = new AltaTrabajador(lbusuario.Text);
            trabajador.MdiParent = this;
            trabajador.Show();
        }

        private void aLTADEEMPRESAToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AltaEmpresa empresa = new AltaEmpresa(lbusuario.Text);
            empresa.MdiParent = this;
            empresa.Show();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aLTADEDEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaDepartamento departamento = new AltaDepartamento(lbusuario.Text);
            departamento.MdiParent = this;
            departamento.Show();
        }

        private void aLTADETRABAJADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AltaTrabajador trabajador = new AltaTrabajador(lbusuario.Text);
            trabajador.MdiParent = this;
            trabajador.Show();
        }
    }
}
