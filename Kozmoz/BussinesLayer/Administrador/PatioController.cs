using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;


namespace BussinesLayer.Administrador
{
    public class PatioController
    {
        public bool alta_patio(int id, patio dto)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var consulta = db.patios.Where(c => c.nombre == dto.nombre && c.idempresafk == id).Count();

                    if (consulta > 0)
                    {

                        return false;
                    }
                    db.patios.Add(dto);
                    if (db.SaveChanges() > 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar  departamento-> " + ex);
                return false;
                throw;

            }

        }
        public List<patio> muestraPatio()
        {
            try
            {

                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var query = (from n in db.patios
                                 select n).ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar  patios-> " + ex);
                throw;
            }
        }

    }
}
