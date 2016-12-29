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
    public partial class AltaDepartamento : Form
    {
        private DepartamentoController funcion = new DepartamentoController();
        private CaracteresValidos validar = new CaracteresValidos();
        private departamento dao = new departamento();
        private String usuarios;
        DateTime fechaHoy = DateTime.Now;
        private LogController funcionlog = new LogController();
        private log daolog = new log();
        private TrabajadorController trabajadores = new TrabajadorController();
        public AltaDepartamento()
        {
            InitializeComponent();

        }
        public AltaDepartamento(String usuario)
        {
            InitializeComponent();
            this.usuarios = usuario;

        }
        private void AltaDepartamento_Load(object sender, EventArgs e)
        {
            muestra();
        }
        public void muestradepartamento(int id)
        {
            treeView1.Nodes.Clear();
            var entidades = trabajadores.muestra_departamento(id);
            foreach (var item in entidades)
            {
                TreeNode root = new TreeNode(item.nombre);
                var trabajadoresd = funcion.muestra_trabajador(item.id);
                foreach(var item2 in trabajadoresd)
                {
                    TreeNode root2 = new TreeNode(item.nombre);
                    root.Nodes.Add(root2);
                }
                treeView1.Nodes.Add(root);
            }
        }
        private void muestra()
        {
            cmbempresa.DataSource = funcion.muestraacombo();
            cmbempresa.DisplayMember = "nombre";
            cmbempresa.ValueMember = "id";
        }
        private void btnregistrar_Click(object sender, EventArgs e)
        {
            if (validar.ValidaTextBoxVacios(this) == false)
            {
                MessageBox.Show("Error debe llenar todos los datos");
                return;
            }
            int idfk = cmbempresa.SelectedIndex + 1;

            dao.idempresafk = idfk;
            dao.nombre = txtnombre.Text;
            dao.nombre_corto = txtnombrecorto.Text;
            dao.imagen = txtimagen.Text;
            dao.no_departamento = txtnum.Text;
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

            if (funcion.inserta_departamento(idfk, dao))
            {
                daolog.fecha = fechaHoy;
                daolog.usuario = this.usuarios;
                daolog.tabla = "Empresa de departameento";
                daolog.registro = txtnombre.Text;
                daolog.operacion = "Creacion";
                funcionlog.registro(daolog);
                MessageBox.Show("El Departamento de la Empresa registarada exitosamente ");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error no se puede registrar ");
            }

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
        private void limpiar()
        {
            txtnombre.Text = "";
            txtnombrecorto.Text = "";
            txtimagen.Text = "";

            txtencargado1.Text = "";
            txtencargado.Text = "";
            txtcorreo1.Text = "";
            txtcorreo2.Text = "";
            txttelefono1.Text = "";
            txttelefono2.Text = "";
        }

        private void cmbempresa_TextChanged(object sender, EventArgs e)
        {
            int id = cmbempresa.SelectedIndex + 1;
            muestradepartamento(id);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
          
            String nombrenodo = e.Node.FullPath;
                  int id = cmbempresa.SelectedIndex + 1;
        //    MessageBox.Show(nombrenodo);
           List<departamento> depa= funcion.listar_departamento(nombrenodo, id);
           var indice = depa[0];
           txtid.Text = indice.id+"";
           txtnombre.Text = indice.nombre;
           txtnombrecorto.Text = indice.nombre_corto;
           txtimagen.Text = indice.imagen;
           txtnum.Text = indice.no_departamento;
            
          txtcalle.Text = indice.calle;
           txtcolonia.Text = indice.colonia;
           txtcp.Text = indice.cp+"";
           txtmunicipio.Text = indice.municipio;
           txtciudad.Text = indice.ciudad;
           txtencargado1.Text = indice.encargado1;
           txtencargado.Text = indice.encargado2;
           txtcorreo1.Text = indice.correo1;
           txtcorreo2.Text = indice.coreo2;
           txttelefono1.Text = indice.telefono1;
           txttelefono2.Text = indice.telefono2;
          
        }

        private void btnactualizar_Click(object sender, EventArgs e)
        {
            if (txtid.Text == "")
            {
                MessageBox.Show("Error al Actualizar", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                return;
            }
            int id = int.Parse(txtid.Text);
            int idfk = cmbempresa.SelectedIndex + 1;
            dao.idempresafk = idfk;
            dao.nombre = txtnombre.Text;
            dao.nombre_corto = txtnombrecorto.Text;
            dao.imagen = txtimagen.Text;
            dao.no_departamento = txtnum.Text;
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
            

            if (funcion.actualizar_departamento(dao,id, idfk))
            {
                MessageBox.Show("Se Actualizo Correctamente ", "", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                limpiar();
               
            }
        }

    }
}
