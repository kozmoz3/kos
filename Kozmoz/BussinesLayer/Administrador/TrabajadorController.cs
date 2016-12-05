using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;


namespace BussinesLayer.Administrador
{
    public class TrabajadorController
    {
        public List<departamento> muestra_departamento(int idfk)
        {
            try {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                 
                    var query =(from n in db.departamentoes
                                    where n.idempresafk ==idfk
                        select n).ToList();
                    return query;
                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error en la lista departamento "+ex);
                throw;
            }
        }

        public void alta_trabajador(trabajador dtotabajador, usuario dtousuario)
        {

            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {

                    
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error alta de trabajador" + ex);
                throw;
            }
        }
    }
}
