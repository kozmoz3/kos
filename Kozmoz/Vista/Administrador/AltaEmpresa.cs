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

        public AltaEmpresa()
        {
            InitializeComponent();
        }
        public AltaEmpresa(String usuario)
        {
            InitializeComponent();
           
            this.usuarios = usuario;
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
            }
            else
            {
                MessageBox.Show("Error no se puede registrar ");
            }
        }

        private void AltaEmpresa_Load(object sender, EventArgs e)
        {

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
    }
}
