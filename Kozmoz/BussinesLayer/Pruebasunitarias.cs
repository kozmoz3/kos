using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataModel;

namespace BussinesLayer
{
    public class Pruebasunitarias
    {
        public List<empresaservicio> index()
        {
            try
            {
                using (kosmozbusEntities dbContext = new kosmozbusEntities())
                {
                    var query = (from n in dbContext.empresaservicios
                                 select n).ToList();
                    return query;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
