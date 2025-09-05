namespace _12._Ciclo_while_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar algoritmo que permita obtener la suma de todos los números impares hasta el 99.

            int contador = 1;
            int suma = 0; //acumulador

            while (contador <= 99)
            {
                suma += contador;
                Console.WriteLine($"{contador}-{suma}");
                contador += 2; //para llegar a los números impares se va sumando de a 2
            }

            Console.WriteLine($"la suma de los números impares hasta el 99 es: {suma}");
        }
    }
}
