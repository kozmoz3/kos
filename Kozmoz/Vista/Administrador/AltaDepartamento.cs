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

    }
}
