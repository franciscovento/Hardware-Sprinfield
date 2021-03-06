using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Hardware.Entidades
{
    public static class ValidarDatos
    {
        public static string ValidarVacio(string x, string campo)
        {
            string msj = "";
            if (String.IsNullOrEmpty(x))
            {
                msj = $"El {campo} no puede estar vacío" + System.Environment.NewLine;
                return msj;
            }

            return msj;
        }

        public static string ValidarNumero(string x, string campo)
        {
            string msj = "";
            if (String.IsNullOrEmpty(x))
            {
                msj = $"El {campo} no puede estar vacío" + System.Environment.NewLine;
                return msj;
            }

            if (!Int32.TryParse(x, out int Salida))
            {
                msj = $"El campo {campo} debe ser un número" + System.Environment.NewLine;
                return msj;
            }

            if (Salida < 0)
            {
                msj = $"El campo {campo} no puede ser menor que cero" + System.Environment.NewLine;
                return msj;
            }

            return msj;
        }

        public static string ValidarFecha(string x, string campo)
        {
            string msj = "";
            if (!DateTime.TryParse(x, out DateTime Salida))
            {
                msj = $"El campo {campo} debe ser una fecha válida" + System.Environment.NewLine;
                return msj;
            }

            return msj;
        }

        public static string ValidarEmail(string x, string campo)
        {
            bool flag = false;
            string msj = "";
            if (String.IsNullOrEmpty(x))
            {
                msj = $"El {campo} no puede estar vacío" + System.Environment.NewLine;
                return msj;
            }

            foreach (char item in x)
            {
                if (item == '@')
                {
                    flag = true;
                }
            }
            string last4 = x.Substring(x.Length - 4);
            if (last4 != ".com")
            {
                
                flag = false;
            }


            if (!flag)
            {
                msj = "El campo debe ser un correo electronico valido" + System.Environment.NewLine;
            }

            return msj;
        }
    }
}
