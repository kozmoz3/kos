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
        public bool actualizar_empresa(empresaservicio dto,int id)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    empresaservicio empresa = (from q in db.empresaservicios
                                              where q.id == id
                                              select q).First();
                    empresa.nombre = dto.nombre;
                    empresa.nombre_corto = dto.nombre_corto;

                    empresa.imagen = dto.imagen;
                    empresa.cabezera = dto.cabezera;
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
        public List<empresaservicio> listar_empresa(String nombre)
        {
            try
            {

                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var consulta = db.empresaservicios.Where(c => c.nombre == nombre).ToList();

                    return consulta;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar  empresa-> " + ex);
              
                throw;

            }
        }
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
