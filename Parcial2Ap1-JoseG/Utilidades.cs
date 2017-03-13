using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parcial2Ap1_JoseG
{
    public class Utilidades
    {
        public int String(string texto)
        {
            int numero = 0;
            int.TryParse(texto, out numero);
            return numero;
        }

        internal static int ToInt()
        {
            try
            {
                Utilidades.ToInt();
                return ToInt();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}
