using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;
namespace BussinesLayer.Administrador
{
    public class LoginController
    {
        public String index(usuario dato)
        {
            try 
            {
                using(kosmozbusEntities db = new kosmozbusEntities())
                {
                    var query =(from n in db.usuarios
                                    where n.usuario1 == dato.usuario1
                                       && n.contrasena == dato.contrasena
                                    select n.usuario1).ToString();
                    return query;
                
                }
 
            }catch (Exception ex) 
            {
                MessageBox.Show("Eror " + ex);
                throw;
            }
        }
    }
}
