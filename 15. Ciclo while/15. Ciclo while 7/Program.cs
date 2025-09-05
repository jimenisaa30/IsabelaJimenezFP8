using System.Timers;

namespace _15._Ciclo_while_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Realizar un algoritmo para determinar cuánto ahorrará una persona en un año, si al final de cada mes deposita cantidades variables de dinero; además, se quiere saber cuánto lleva ahorrado cada mes

            int dinero = 0; //Cantidad ahorrada
            int cantMes = 0; //Sueldo del mes
            int contador = 1; //Contador para los meses

           while(contador <= 12)
           {
                Console.WriteLine($"Ingrese el monto ahorrado en el mes {contador}");
                cantMes= Convert.ToInt32( Console.ReadLine() );

                dinero += cantMes;
                Console.WriteLine($"El monto ahorrado para el mes {contador} es de: {dinero}");
                contador++;
           }
            Console.WriteLine($"El total ahorrado para le final del año es de {dinero}");
        }
    }
}
