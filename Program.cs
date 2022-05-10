using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args) //Entry Point
        {
            //namespace, classe, metodo
            //System.Console.WriteLine("Inserisci il primo numero:");
            //string s1;
            //s1 = System.Console.ReadLine();

            //System.Console.WriteLine("Inserisci il secondo numero:");
            //string s2;
            //s2 = System.Console.ReadLine();

            //int v1 = Convert.ToInt32(s1);
            //int v2 = Convert.ToInt32(s2);

            //System.Console.WriteLine("Il risultato della moltiplicazione è {0}", Multiply(v1, v2));

            // Correzione
            int i1, i2;
            Console.WriteLine("Inserisci il primo numero: ");
            if(!int.TryParse(Console.ReadLine(), out i1))
            {
                Console.WriteLine("Errore nell'inserimento");
                System.Environment.Exit(1);
            }
            Console.WriteLine("Inserisci il secondo numero:");
            if (!int.TryParse(Console.ReadLine(), out i2))
            {
                Console.WriteLine("Errore nell'inserimento");
                System.Environment.Exit(1);
            }
            System.Console.WriteLine("Il risultato della moltiplicazione è {0}", Multiply(i1, i2));
        }
        static int Multiply(int v1, int v2)
        { 
            return v1 * v2;
        }
    }
}

