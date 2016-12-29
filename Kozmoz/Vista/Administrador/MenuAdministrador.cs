using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataModel;
using BussinesLayer.Administrador;
using BussinesLayer;
using Validaciones;

namespace Vista.Administrador
{
   // public partial class MenuAdministrador : DevComponents.DotNetBar
    public partial class MenuAdministrador : Form
    {
        private DepartamentoController departamento = new DepartamentoController();
        private TrabajadorController trabajadores = new TrabajadorController();
        public MenuAdministrador()
        {
            InitializeComponent();
            muestratreview();
        }
        public MenuAdministrador(String usuario)
        {
            InitializeComponent();
            lbusuario.Text = usuario;
            muestratreview();
        }
        
        private void MenuAdministrador_Load(object sender, EventArgs e)
        {

        }

        public void muestratreview()
        {
            treeView1.Nodes.Clear();
            var entidades = departamento.muestraacombo();
            TreeNode newNode = new TreeNode("[ DEPARTAMENTOS ]");
            int i = 0;
            foreach (var item in entidades)
            {
                TreeNode root = new TreeNode(item.nombre);
                var depa = trabajadores.muestra_departamento(item.id);
                
                foreach (var item2 in depa)
                {
                   // MessageBox.Show(depa.Count+"");
                    if (i == 0)
                    {
                        root.Nodes.Add(newNode);
                    }
                    
                    if (i == depa.Count)
                    {
                        MessageBox.Show( "entro");
                        i = 0;
                    }
                    TreeNode root2 = new TreeNode(item2.nombre);
                    // newNode.Nodes.Add(root2);
                     root.Nodes.Add(root2);
                    i++;
                }
               
                treeView1.Nodes.Add(root);
            }
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

       

        private void aLTADEDEPARTAMENTOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aLTADETRABAJADORToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void aLTADETIPOSDEUSUARIOToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Tipos_Usuarios tipos = new Tipos_Usuarios();
            tipos.MdiParent = this;
            tipos.Show();
        }

        private void aLTADEPATIOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Alta_Patios patios = new Alta_Patios();
            patios.MdiParent = this;
            patios.Show();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void aLTADEEMPRESAToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            AltaEmpresa empresa = new AltaEmpresa(lbusuario.Text);
            empresa.MdiParent = this;
            empresa.Show();
        }

        private void aLTADEPATIOSToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Alta_Patios patios = new Alta_Patios();
            patios.MdiParent = this;
            patios.Show();
        }

        private void btacerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aLTADEPATIOSToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            Alta_Patios patios = new Alta_Patios();
            patios.MdiParent = this;
            patios.Show();
        }

        private void aLTADEDEPARTAMENTOToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AltaDepartamento departamento = new AltaDepartamento(lbusuario.Text);
            departamento.MdiParent = this;
            departamento.Show();
        }

        private void aLTADETRABAJADORToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            AltaTrabajador trabajador = new AltaTrabajador(lbusuario.Text);
            trabajador.MdiParent = this;
            trabajador.Show();
        }

      

       
    }
}
