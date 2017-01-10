using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;
using System.Windows.Forms;

namespace BussinesLayer.Administrador
{
    public class VehiculoController
    {
        public List<patio> muestra_patio(int idempresafk)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {

                    var query = (from n in db.patios
                                 where n.idempresafk == idempresafk
                                 select n).ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al listar patios de las empresa -> " + ex);
                
                throw;

            }
        }
        public bool alta_vehiculo(vehiculo dto, String patio)
        {
            try
            {
                using (kosmozbusEntities db = new kosmozbusEntities())
                {
                    var query = (from n in db.patios
                                 where n.nombre == patio
                                &&
                                n.idempresafk == dto.idempresafk
                                 select n).First();
                    vehiculo modelo = new vehiculo();

                    modelo.idempresafk = dto.idempresafk;
                    modelo.numero = dto.numero;
                    modelo.capacidad = dto.capacidad;
                    modelo.tipo = dto.tipo;
                    modelo.matricula = dto.matricula;
                    modelo.version = dto.version;
                    modelo.ano = dto.ano;
                    modelo.ano_adquicision = dto.ano_adquicision;
                    modelo.motor = dto.motor;
                    modelo.km_mantenimiento = dto.km_mantenimiento;
                    modelo.status = dto.status;
                    modelo.fecha_creacion = dto.fecha_creacion;

                    db.vehiculoes.Add(modelo);
                    if (db.SaveChanges() > 0)
                    {
                        var query2 = (from n in db.vehiculoes
                                     where n.numero == dto.numero
                                    &&
                                    n.idempresafk == dto.idempresafk
                                     select n).First();
                        patio_vehiculo dtopatio = new patio_vehiculo();
                        dtopatio.idpatiofk = query.id;
                        dtopatio.idvehiculofk = query2.id;
                        db.patio_vehiculo.Add(dtopatio);
                        if(db.SaveChanges() > 0)
                        {
                            return true;
                        }
                       return false;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar  vehiculo -> " + ex);
                return false;
                throw;

            }

        }

    }
}
