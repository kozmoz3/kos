using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;

namespace BussinesLayer.Administrador
{
    public class EmpresaController
    {
        public bool altaempresa(empresaservicio dto)
        {
            try
            {
                String nombre = dto.nombre;
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var consulta = db.empresaservicios.Where(c => c.nombre == dto.nombre).Count();

                    if (consulta > 0)
                    {
                        return false;
                    }
                     db.empresaservicios.Add(dto);
                     if (db.SaveChanges() > 0)
                     {
                         return true;
                     }
                     return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar  empresa-> " + ex);
                return false;
                throw;
                
            }
        }
    }
}
