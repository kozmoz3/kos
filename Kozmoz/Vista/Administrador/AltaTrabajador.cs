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
    public partial class AltaTrabajador : Form
    {
        private DepartamentoController funcion = new DepartamentoController();
        private TrabajadorController trabajador = new TrabajadorController();
        private trabajador dtotrabajador = new trabajador();
        private usuario dtousuario = new usuario();
        DateTime fechaHoy = DateTime.Now;
        private CaracteresValidos validar = new CaracteresValidos();

        private String usuarios;

        public AltaTrabajador()
        {
            InitializeComponent();
        }
        public AltaTrabajador(String usuario)
        {
            InitializeComponent();
            this.usuarios = usuario;
        }

        private void AltaTrabajador_Load(object sender, EventArgs e)
        {
            muestraempresa();
        }
        private void muestraempresa()
        {
            cmbempresa.DataSource = funcion.muestraacombo();
            cmbempresa.DisplayMember = "nombre";
            cmbempresa.ValueMember = "id";
        }
        private void muestra_departamento(int id)
        {
            
            cmbdepartamento.DataSource = trabajador.muestra_departamento(id);
            cmbdepartamento.DisplayMember = "nombre";
            cmbdepartamento.ValueMember = "id";
        }

        private void cmbempresa_TextChanged(object sender, EventArgs e)
        {
            int id = cmbempresa.SelectedIndex + 1;
            muestra_departamento( id);
        }

        private void limpiar()
        {
            txtnoempleado.Text = "";
            txtnombre.Text = "";
            txtedad.Text = "";
            txttelefono.Text = "";
            txtcargo.Text = "";
            txtimagen.Text = "";
            txtusuario.Text = "";
            txtcontraseña.Text = "";
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (validar.ValidaTextBoxVacios(this) == false)
            {
                MessageBox.Show("Error debe llenar todos los datos");
                return;
            }
                int idfk = cmbempresa.SelectedIndex + 1;
                String depa = cmbdepartamento.Text;

                dtotrabajador.genero = cmbgenero.Text;
                dtotrabajador.numero_empleado = txtnoempleado.Text;
                dtotrabajador.nombre = txtnombre.Text;
                dtotrabajador.edad = txtedad.Text;
                dtotrabajador.telefono = txttelefono.Text;
                dtotrabajador.cargo = txtcargo.Text;
                dtotrabajador.imagen = txtimagen.Text;
                dtotrabajador.fecha_creaccion = fechaHoy;

             //   dtotrabajador.usuarios = txtusuario.Text;
               // dtotrabajador.pass = txtcontraseña.Text = "";

              if(trabajador.alta_trabajador(idfk, depa, dtotrabajador))
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
