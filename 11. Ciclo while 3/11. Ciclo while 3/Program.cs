namespace _11._Ciclo_while_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. 

            
            int contador = 0;
            int acumulador = 0;

            Console.WriteLine("Ingrese numeros positivos para realizar su suma");
            contador = Convert.ToInt32( Console.ReadLine() );

            while ( contador > 0)
            {
                acumulador += contador;
            }
            Console.WriteLine($"La suma de los números es {acumulador}");
        }
    }
}
