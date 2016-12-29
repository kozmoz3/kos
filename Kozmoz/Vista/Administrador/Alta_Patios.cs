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
    public partial class Alta_Patios : Form   
    {
        private DepartamentoController funcion = new DepartamentoController();
        private PatioController functionpatio = new PatioController();
        private CaracteresValidos validar = new CaracteresValidos();
        private patio dao = new patio();
        DateTime fechaHoy = DateTime.Now;
        public Alta_Patios()
        {
            InitializeComponent();
            muestra();
        }
        private void muestra()
        {
            cmbempresa.DataSource = funcion.muestraacombo();
            cmbempresa.DisplayMember = "nombre";
            cmbempresa.ValueMember = "id";
        }
        private void limpiar()
        {
            txtnombre.Text = "";
            txtnombrecorto.Text = "";
           // txtimagen.Text = "";

            txtencargado1.Text = "";
            txtencargado.Text = "";
            txtcorreo1.Text = "";
            txtcorreo2.Text = "";
            txttelefono1.Text = "";
            txttelefono2.Text = "";
        }

        private void Alta_Patios_Load(object sender, EventArgs e)
        {

        }

        private void ribbonControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnguardar_Click(object sender, EventArgs e)
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
          
            dao.capacidad = txtcapacidad.Text;
          
            dao.calle = txtcalle.Text;
            dao.colonia = txtcolonia.Text;
            dao.cp = txtcp.Text;
            dao.municipio = txtmunicipio.Text;
            dao.ciudad = txtciudad.Text;
            dao.encargado1 = txtencargado1.Text;
            dao.encargado2 = txtencargado.Text;
            dao.correo1 = txtcorreo1.Text;
            dao.correo2 = txtcorreo2.Text;
            dao.telefono1 = txttelefono1.Text;
            dao.telefono2 = txttelefono2.Text;
            dao.fecha_creacion = fechaHoy;

            if (functionpatio.alta_patio(idfk, dao))
            {
                MessageBox.Show("El Patio de la Empresa registarada exitosamente ");
                limpiar();
            }
            else
            {
                MessageBox.Show("Error no se puede registrar ");
            }
        }
    }
}
