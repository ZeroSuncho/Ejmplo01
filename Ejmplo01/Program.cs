using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejmplo01
{
    class Program
    {
        string msg = "";
        int A = 5;
        int B = 23;
        static void Main(string[] args)
        {
            int Cont = 1;
            int Res = 0;

            string Entrada;

            Console.WriteLine("Inserte dos números separados por un espacio...");
            Entrada = Console.ReadLine();

            Program met = new Program();
            if (met.ValidaEntrada(Entrada)==true)
            {
                Console.WriteLine($"Los multiplos de [{met.A}] con limite al [{met.B}], son:");
                while ((met.A * Cont) <= met.B)
                {
                    Res = met.A * Cont;
                    Console.WriteLine(">> {0} ", Res);
                    //Console.WriteLine(Cont);
                    Cont += 1;
                }
            }
            
            Console.ReadKey();
         }
    
        public bool ValidaEntrada(string INCad)
        {
            string[] Splient;
            int salida = 0;
            try
            {
                Splient = INCad.Split(' ');

                if (Splient.Length != 2)
                { msg = "Solo se deben insertar 2 valores."; Console.WriteLine(msg); return false; }

                if (!int.TryParse(Splient[0].ToString(), out salida))
                { msg = "El primer valor debe ser un número."; Console.WriteLine(msg); return false; }
                else
                { A = Convert.ToInt32(Splient[0].ToString()); }

                if (!int.TryParse(Splient[1].ToString(), out salida))
                { msg = "El segundo valor debe ser un número."; Console.WriteLine(msg); return false; }
                else
                { B = Convert.ToInt32(Splient[1].ToString()); }

                if (A > B)
                { msg = "El Primer valor debe ser menor al segundo."; Console.WriteLine(msg); return false; }

                if (A <= 0 || B <= 0)
                { msg = "Los registros deben ser mayores a 0."; Console.WriteLine(msg); return false; }

                msg = "";
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
