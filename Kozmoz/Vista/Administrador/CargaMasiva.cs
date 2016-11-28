using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using BussinesLayer.Administrador;
using DataModel;

namespace Vista.Administrador
{
    public partial class CargaMasiva : Form
    {
        ArchivoController archivo = new ArchivoController();
        public CargaMasiva()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnseleccionar_Click(object sender, EventArgs e)
        {
            OpenFileDialog buscar = new OpenFileDialog();
            
            if(buscar.ShowDialog() == DialogResult.OK){
                String nombre = buscar.FileName;
                String valida = nombre.Substring((nombre.Length - 3), 3);
                String valida2 = nombre.Substring((nombre.Length - 4), 4);
             
                if (valida.Contains("xls") || valida2.Contains("xlsx"))
                {
                    txtruta.Text = nombre;
                    
         
                }
                else {
                    MessageBox.Show("El archivo no es de lectura");
                }
                
            }
        }

        private void btnvalidar_Click(object sender, EventArgs e)
        {
            if(txthoja.Text == "")
            {
                MessageBox.Show("ingrese el nombre de la hoja a leer");
                return;
            }
          //  MessageBox.Show(txtruta.Text);
            if(archivo.validar(txtruta.Text,txthoja.Text))
            {
            }
        }
    }
}
