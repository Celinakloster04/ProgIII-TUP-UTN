using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PaginaPrincipal
{
    public static class GlobalFunctions
    {
         public static bool EsNombreValido(string nombre)
         {
            foreach (char c in nombre)
            {
                if(char.IsLetter(c) == false)
                {
                    return false;
                }
            }
            return true;
         }

        public static bool OrdenarAlfabeticamente(ListBox lbNombres)
        {
            return lbNombres.Sorted = true;
        }
    }
}
