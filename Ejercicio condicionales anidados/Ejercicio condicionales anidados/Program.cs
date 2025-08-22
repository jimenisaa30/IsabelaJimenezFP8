using System.Transactions;

namespace Ejercicio_condicionales_anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float calf1 = 0;
            float calf2 = 0;
            float calf3 = 0;
            float promedio = (calf1 + calf2 + calf3) / 3;

            Console.WriteLine("Ingrese la calificación 1");
            calf1 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación 2");
            calf2 = Convert.ToSingle(Console.ReadLine());
            
            Console.WriteLine("Ingrese la calificación 3");
            calf3 = Convert.ToSingle(Console.ReadLine());

            if(9.5 < promedio &&  promedio < 10)
            {
                if (8.5 < promedio && promedio < 9.4)
                {
                    Console.WriteLine("Muy Bien");
                }
                else
                {
                    Console.WriteLine("Excelente");
                }
            }
            else
            {
                if (7.5 < promedio && promedio < 8.4)
                {
                    Console.WriteLine("Bien");
                }
                else
                {
                    Console.WriteLine("Error, intente de nuevo");
                }
            }
        }
    }
}
