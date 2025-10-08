using System.Runtime.InteropServices.Marshalling;

namespace _25._Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio: Algoritmo que permita solicitar 10 números, los cuales serán almacenados en un arreglo unidimensional, al final, debe visualizar el promedio de esos números.*/

            int[] numeros = new int[10];
            int suma = 0;

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine($"Ingrese el numero para la posición {i + 1} con índice {i}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());

                suma += numeros[i];
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write(numeros[i]+"|");
            }
            
            int prom = suma / numeros.Length;
            Console.WriteLine(" El promedio de los números el vector es:" + prom);

        }
    }
}
