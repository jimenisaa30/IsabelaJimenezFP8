using System.Security.Cryptography;
using System.Timers;

namespace Parcial_1._Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string Nombre = " ";
            int Años = 0;
            float CalfAñoActual = 0f;
            float CalfAñoAnterior = 0f;
            
            float Porcentaje = 0f;
            int SueldoBase = 2500000;
            int ValorAumento = 0;

            Console.WriteLine("Ingrese el nombre de el empleado");
            Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese la calificación del empleado del año actual. Recuerde que las calificaciones permitidas son: 0.0, 0.4 ,0.6 y 1.0");
            CalfAñoActual = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese la calificación del empleado en el año anterior. Recuerde que las calificaciones permitidas son: 0.0, 0.4 ,0.6 y 1.0");
            CalfAñoAnterior = Convert.ToSingle(Console.ReadLine());

            if (CalfAñoActual == 0.0 || CalfAñoActual == 0.4 || CalfAñoActual == 0.6 || CalfAñoActual == 1.0 && CalfAñoAnterior == 0.0 || CalfAñoAnterior == 0.4 || CalfAñoAnterior == 0.6 || CalfAñoAnterior == 1.0)
            {
                float Prom = (CalfAñoActual + CalfAñoAnterior) / 2;
                Console.WriteLine($"El promedio de las dos calificaciones es de {Prom} ");
                Console.WriteLine();
                Console.WriteLine("Ingrese la cantidad de años que el empleado ha trabajado en la empresa");
                Años = Convert.ToInt32(Console.ReadLine());

                if (Años < 1)
                {
                    Porcentaje = 0;
                    ValorAumento = Convert.ToInt32 (SueldoBase * (Porcentaje));

                    Console.WriteLine($"El empleado {Nombre} tiene un promedio de calificación {Prom}y ha trabajado {Años} años en la empresa, Por lo tanto se le hace un aumento del {Porcentaje} los que son {ValorAumento} pesos");
                }
                else if (Años > 5)
                {
                    Porcentaje = 0.3f;
                    ValorAumento = Convert.ToInt32(SueldoBase * (Porcentaje));

                    Console.WriteLine($"El empleado {Nombre} tiene un promedio de calificación {Prom}y ha trabajado {Años} años en la empresa, Por lo tanto se le hace un aumento del {Porcentaje} los que son {ValorAumento} pesos");

                }
                else if (Años > 0 && Años <= 5 && Prom >= 0 && Prom < 0.4)
                {
                    Porcentaje = 0.05f;
                    ValorAumento = Convert.ToInt32(SueldoBase * (Porcentaje));

                    Console.WriteLine($"El empleado {Nombre} tiene un promedio de calificación {Prom}y ha trabajado {Años} años en la empresa, Por lo tanto se le hace un aumento del {Porcentaje} los que son {ValorAumento} pesos");
                }
                else if (Años > 0 && Años <= 5 && Prom >= 0.4 && Prom < 0.6)
                {
                    Porcentaje = 0.1f;
                    ValorAumento = Convert.ToInt32(SueldoBase * (Porcentaje));

                    Console.WriteLine($"El empleado {Nombre} tiene un promedio de calificación {Prom}y ha trabajado {Años} años en la empresa, Por lo tanto se le hace un aumento del {Porcentaje} los que son {ValorAumento} pesos");

                }
                else if (Años > 0 && Años <= 5 && Prom >= 0.6 && Prom < 1.0)
                {
                    Porcentaje = 0.2f;
                    ValorAumento = Convert.ToInt32(SueldoBase * (Porcentaje));

                    Console.WriteLine($"El empleado {Nombre} tiene un promedio de calificación {Prom}y ha trabajado {Años} años en la empresa, Por lo tanto se le hace un aumento del {Porcentaje} los que son {ValorAumento} pesos");

                }
            }
            else
            {
                Console.WriteLine("Error, intente de nuevo");
            }
        }
    }
}
