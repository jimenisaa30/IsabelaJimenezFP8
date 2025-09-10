namespace _21._For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Programa que genera y suma los primeros 5 números enteros

            int acumulador = 0;
            for (int i = 0; i <= 5; i++)//I es la variable que funciona como el contador
            {
                acumulador += i;
            }

            Console.WriteLine($"La suma de los primeros 5 números enteros es {acumulador}");
        }
    }
}
