using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;
namespace BussinesLayer.Administrador
{
    public class Tipo_VehiculoController
    {
        public bool alta_tipo( tipo_vehiculo dto)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                   
                  
                    db.tipo_vehiculo.Add(dto);
                    if (db.SaveChanges() > 0)
                    {
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error alta de tipo de vehiculo" + ex);
                return false;
                throw;
            }
        }
    }
}
