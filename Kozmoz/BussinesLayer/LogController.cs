using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;

namespace BussinesLayer
{
    public class LogController
    {
        public void registro(log datos)
        {
            try {
                using(kosmozbusEntities db = new kosmozbusEntities())
                {
                    db.logs.Add(datos);
                    db.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error l registra log "+ex);
                throw;
            }
        }
    }
}
