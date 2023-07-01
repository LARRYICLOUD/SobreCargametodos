using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SobreCargametodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //variable para recibir desde Concatenar
            string nombreYapellido;
            //instancia 
            Nombres nombres = new Nombres();

            nombreYapellido = nombres.Concatenar("LARRYSALSA", "DE CALI", "MAGISTRAL");


            //Mostrando las cadenas ya concatenadas

            Console.WriteLine(nombreYapellido);
        }



    }
    class Nombres
    {

        //metodo
        public string Concatenar(string nombrePa, string apellidoPa)
        {
            string nombreApellido;
            nombreApellido = nombrePa + "" + apellidoPa;
            return nombreApellido;
        }

        //Sobrecarga del metodo Concatenar
        public string Concatenar(string nombrePa, string apellidoPa, string apellido2Pa)
        {

            string nombreApellido;
            nombreApellido = nombrePa + "" + apellidoPa + "" + apellido2Pa;
            return nombreApellido;
        }


    }

        
            
    
}
