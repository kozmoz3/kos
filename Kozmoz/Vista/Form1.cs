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
namespace Vista
{
    public partial class Form1 : Form
    {
        Prueba pr = new Prueba();
        public Form1()
        {
            InitializeComponent();
            datos.DataSource = pr.index();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            datos.DataSource = pr.index();
        }
    }
}
