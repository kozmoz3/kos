using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;
namespace BussinesLayer.Administrador
{
    public class EstatusController
    {

        public bool alta_estatus(estatu dto)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {


                    db.estatus.Add(dto);
                    if (db.SaveChanges() > 0)
                    {
                        return true;
                    }
                    return false;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error alta de tipo estatus" + ex);
                return false;
                throw;
            }
        }
    }
}
