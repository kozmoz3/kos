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
        public bool actualizar_departamento(departamento dto,int id, int idempresafk)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    departamento empresa = (from q in db.departamentoes
                                            where q.id == id
                                            where q.idempresafk == idempresafk 
                                           
                                               select q).First();
                    empresa.nombre = dto.nombre;
                    empresa.nombre_corto = dto.nombre_corto;

                    empresa.imagen = dto.imagen;
                    empresa.no_departamento = dto.no_departamento;
                    empresa.fecha_creacion = dto.fecha_creacion;
                    empresa.calle = dto.calle;
                    empresa.colonia = dto.colonia;
                    empresa.cp = dto.cp;
                    empresa.municipio = dto.municipio;
                    empresa.ciudad = dto.ciudad;
                    empresa.encargado1 = dto.encargado1;
                    empresa.encargado2 = dto.encargado2;
                    empresa.correo1 = dto.correo1;
                    empresa.coreo2 = dto.coreo2;
                    empresa.telefono1 = dto.telefono1;
                    empresa.telefono2 = dto.telefono2;

                    if (db.SaveChanges() > 0)
                    {
                        return true;
                    }
                    return false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actulizar  empresa-> " + ex);
                return false;
                throw;

            }
        }
        public List<departamento> listar_departamento(String nombre,int idserviciofk)
        {
            try
            {

                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var consulta = db.departamentoes.Where(c => c.nombre == nombre && c.idempresafk == idserviciofk).ToList();

                    return consulta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar  empresa-> " + ex);

                throw;

            }
        }
        public List<trabajador> muestra_trabajador(int iddepartamentofk)
        {
            try
            {

                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var query = db.trabajadors.Where(c => c.iddepartamentofk ==iddepartamentofk).ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar  empresas-> " + ex);
                throw;
            }
        }
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

        public bool inserta_departamento(int id, departamento dto)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var consulta = db.patios.Where(c => c.nombre == dto.nombre && c.idempresafk ==id).Count();
                    
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
