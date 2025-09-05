namespace _14._Ciclo_while_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n.

            int contador = 1;
            int contadorPares = 0;
            int rango = 0;

            Console.WriteLine("Ingrese el rango a evaluar");
            rango = Convert.ToInt32(Console.ReadLine());

            while (contador <= rango)
            {
                if (contador % 2 == 0)
                {
                    contadorPares++;
                }
            }

            Console.WriteLine($"La cantidad de números pares del 1 hasta el {rango} es de {contadorPares}");
        }
    }
}
