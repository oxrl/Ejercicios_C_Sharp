using System;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string dato1 = "";
            string dato2 = "";
            int res = 0;
            Console.WriteLine("Ingrese el Primer Numero :");
            dato1 = Console.ReadLine();
            Console.WriteLine("Ingrese el Segundo Numero :");
            dato2 = Console.ReadLine();
            res = Convert.ToInt32(dato1) + Convert.ToInt32(dato2);
            Console.WriteLine("La respuesta es : {0}",res);
            Console.WriteLine("Número de argumentos : {0}",args.Length);

            

        }
    }
}
