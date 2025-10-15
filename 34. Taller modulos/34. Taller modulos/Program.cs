using System.Numerics;

namespace _34._Taller_modulos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string PalabraIngresada=IngresarPalabra();
            VectorCar(PalabraIngresada); //Este módulo debe contar con un parámetro en el contexto del Main
            ContarLetras(PalabraIngresada);
        }
        static string IngresarPalabra()
        {
            Console.WriteLine("Ingrese una palabra");
            string palabra = Console.ReadLine();

            return palabra;
        }

        static char[] VectorCar(string palabra)
        {
            
            for (int i = 0; i < palabra.Length; i++)
            {
                Console.Write(palabra[i] + "|");
            }
            Console.WriteLine();

            return palabra.ToCharArray();
        }

        static void ContarLetras(char palabra)
        {
            do
            {
                int contadorVocales = 0;
                int contadorConsonantes = 0;
                if (palabra == 'a' && palabra == 'e' && palabra == 'i' && palabra == 'o' && palabra == 'u')
                {
                    contadorVocales++;
                }
                else
                {
                    contadorConsonantes++;
                }
            }while(true);

            return contadorVocales;

            Console.WriteLine($"La palabra ingresada contiene {contadorVocales}")
        }

    }
}
