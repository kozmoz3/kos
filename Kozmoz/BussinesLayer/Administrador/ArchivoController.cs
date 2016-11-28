using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinqToExcel;
using DataModel;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;

namespace BussinesLayer.Administrador
{
    public class ArchivoController
    {
        
        public bool validar(String ruta, String hoja)
        {
            String r = "@C:\\Users\\ESosa\\Desktop\\Ciudad de México.xls";
           String ru = Path.GetDirectoryName(r);
            var book = new ExcelQueryFactory(ru);
            MessageBox.Show(book + "");
            book.DatabaseEngine = LinqToExcel.Domain.DatabaseEngine.Ace;
            try
            {
                //string path = ConfigurationManager.AppSettings["PATH_IMPORTACION"];
             

                MessageBox.Show(book+"");
                var res = (from row in book.Worksheet(hoja)
                           let item = new ciudad
                           {
                               clavec = row[15].Cast<int>(),
                               nombrec = row[6].Cast<String>()
                           }
                           select item).ToList();

                foreach (var item in res)
                {
                    MessageBox.Show(item.clavec + "");
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror "+ex);
                throw;
            }
        }
    }
}
