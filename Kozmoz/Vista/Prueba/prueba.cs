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

namespace Vista.Prueba
{
    public partial class prueba : Form
    {
        Pruebasunitarias pr = new Pruebasunitarias();
        public prueba()
        {
            InitializeComponent();
            datos.DataSource = pr.index();
        }

        private void prueba_Load(object sender, EventArgs e)
        {
            datos.DataSource = pr.index();
        }
    }
}
