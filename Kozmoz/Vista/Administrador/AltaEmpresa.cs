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
    public partial class AltaEmpresa : Form
    {
        private empresaservicio dao = new empresaservicio();
        DateTime fechaHoy = DateTime.Now;
        private LogController funcionlog = new LogController();
        private log daolog = new log();
        private EmpresaController funcion = new EmpresaController();
        private CaracteresValidos validar = new CaracteresValidos();
        private String usuarios;
        private DepartamentoController departamento = new DepartamentoController();
        private TrabajadorController trabajadores = new TrabajadorController();

        public AltaEmpresa()
        {
            InitializeComponent();
        }
        public AltaEmpresa(String usuario)
        {
            InitializeComponent();

            this.usuarios = usuario;
            muestratreview();
        }
        private void AltaEmpresa_Load(object sender, EventArgs e)
        {
            txtid.Text = "";
        }
     

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
        {

            if (validar.ValidaTextBoxVacios(this) == false)
            {
                MessageBox.Show("Error todos los campos deben de ser llenados");
                return;
            }

            dao.nombre = txtnombre.Text;
            dao.nombre_corto = txtnombrecorto.Text;
            dao.imagen = txtimagen.Text;
            dao.cabezera = txtcabezera.Text;
            dao.fecha_creacion = fechaHoy;
            dao.calle = txtcalle.Text;
            dao.colonia = txtcolonia.Text;
            dao.cp = int.Parse(txtcp.Text);
            dao.municipio = txtmunicipio.Text;
            dao.ciudad = txtciudad.Text;
            dao.encargado1 = txtencargado1.Text;
            dao.encargado2 = txtencargado.Text;
            dao.correo1 = txtcorreo1.Text;
            dao.coreo2 = txtcorreo2.Text;
            dao.telefono1 = txttelefono1.Text;
            dao.telefono2 = txttelefono2.Text;

            if (funcion.altaempresa(dao))
            {
                daolog.fecha = fechaHoy;
                daolog.usuario = this.usuarios;
                daolog.tabla = "Empresa de servicio";
                daolog.registro = txtnombre.Text;
                daolog.operacion = "Creacion";
                funcionlog.registro(daolog);
                MessageBox.Show("Empresa registarada exitosamente ");
                limpiar();
                muestratreview();
            }
            else
            {
                MessageBox.Show("Error no se puede registrar ");
            }
        }
        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if(txtid.Text =="")
            {
                MessageBox.Show("Error al registra ", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            dao.nombre = txtnombre.Text;
            dao.nombre_corto = txtnombrecorto.Text;
            dao.imagen = txtimagen.Text;
            dao.cabezera = txtcabezera.Text;
            dao.fecha_creacion = fechaHoy;
            dao.calle = txtcalle.Text;
            dao.colonia = txtcolonia.Text;
            dao.cp = int.Parse(txtcp.Text);
            dao.municipio = txtmunicipio.Text;
            dao.ciudad = txtciudad.Text;
            dao.encargado1 = txtencargado1.Text;
            dao.encargado2 = txtencargado.Text;
            dao.correo1 = txtcorreo1.Text;
            dao.coreo2 = txtcorreo2.Text;
            dao.telefono1 = txttelefono1.Text;
            dao.telefono2 = txttelefono2.Text;
            int id = int.Parse(txtid.Text);
            if(funcion.actualizar_empresa(dao,id)){
                MessageBox.Show("Error al registra ", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
                txtid.Text = "";
            }
        }
        public void muestratreview()
        {
            var entidades = departamento.muestraacombo();
            foreach (var item in entidades)
            {
                TreeNode root = new TreeNode(item.nombre);
                var depa = trabajadores.muestra_departamento(item.id);
                foreach (var item2 in depa)
                {
                    TreeNode root2 = new TreeNode(item2.nombre);
                    root.Nodes.Add(root2);
                }

                treeView1.Nodes.Add(root);
            }
        }
        

        private void limpiar()
        {
            txtnombre.Text = "";
            txtnombrecorto.Text = "";
            txtimagen.Text = "";
            txtcabezera.Text = "";
            txtencargado1.Text = "";
            txtencargado.Text = "";
            txtcorreo1.Text = "";
            txtcorreo2.Text = "";
            txttelefono1.Text = "";
            txttelefono2.Text = "";
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //MessageBox.Show(treeView1.SelectedNode + "");
           String nodo = e.Node.Parent+"";
           String nombrenodo = e.Node.FullPath;
           if (nodo != "")
           {
              // MessageBox.Show("nodo hijo");
           }
           else
           {

              List<empresaservicio> repartir = funcion.listar_empresa(nombrenodo);
               var indice = repartir[0];
               txtid.Text = indice.id+"";
              txtnombre.Text = indice.nombre;
              txtnombrecorto.Text = indice.nombre_corto;
              txtimagen.Text = indice.imagen;
              txtcabezera.Text = indice.cabezera;
              txtencargado1.Text = indice.encargado1;
              txtencargado.Text = indice.encargado2;
              txtcorreo1.Text = indice.correo1;
              txtcorreo2.Text = indice.coreo2;
              txttelefono1.Text = indice.telefono1;
              txttelefono2.Text = indice.telefono2;

             //  MessageBox.Show("nodo padre");
           }
          // MessageBox.Show(e.Node.Parent+"");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

       
    }
}
