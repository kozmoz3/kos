using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;
using DataModel;
using Vista.Administrador;
namespace Vista
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            //CargaMasiva c = new CargaMasiva();
           // AltaEmpresa c = new AltaEmpresa();
          //  AltaDepartamento c = new AltaDepartamento();
            MenuAdministrador c = new MenuAdministrador("enrique");
            c.Show();
        }
    }
}
