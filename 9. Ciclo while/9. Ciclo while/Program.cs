namespace _9._Ciclo_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int acumulador = 0;
            
            while (contador <= 5)
            {
                acumulador += contador; // al cuamulador se le suma lo que lleva el contador
                Console.WriteLine($"Contador = {contador} , Acumulador = {acumulador}"); // muestra el proceso
                contador++; // el contador aumenta en 1
            }

            Console.WriteLine($"La suma de los primeros 5 números enteros es: {acumulador}");
        }
    }
}
