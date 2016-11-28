using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Validaciones
{
    public class CaracteresValidos
    {
        public Boolean vacio(String datos)
        {
            if (String.IsNullOrEmpty(datos))
            {
                return false;
            }
            else
                return true;
        }

      /*  public Boolean sin_espcios(String dato)
        { 
        
        }*/
        

 public bool ValidaTextBoxVacios(Form formulario){
 
    foreach (Control control in formulario.Controls){
 
       if(control.GetType().Equals(typeof(TextBox))){
 
           if(control.Text.Equals("")){
 
              return false;
           }                    
       }         
    }
    return true;
  }
    }
}
