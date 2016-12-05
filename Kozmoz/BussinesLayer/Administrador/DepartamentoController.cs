using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;


namespace BussinesLayer.Administrador
{
    public class DepartamentoController
    {
        public List<empresaservicio> muestraacombo()
        {
            try
            {

                using (kosmozbusEntities db = new kosmozbusEntities())
                { 
                    var query =(from n in db.empresaservicios
                        select n).ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar  empresas-> " + ex);
                throw;
            }
        }
        public List<departamento> muestradepartamento()
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var query = (from n in db.departamentoes
                                 select n).ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar  empresas-> " + ex);
                throw;
            }
        }

        public bool inserta_departamento(int id,departamento dto)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var consulta = db.departamentoes.Where(c => c.nombre == dto.nombre && c.idempresafk ==id).Count();
                    
                    if (consulta > 0)
                    {
                       
                        return false;
                    }
                    db.departamentoes.Add(dto);
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
    }
}
