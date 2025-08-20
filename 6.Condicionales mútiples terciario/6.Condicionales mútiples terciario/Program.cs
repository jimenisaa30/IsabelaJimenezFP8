namespace _6.Condicionales_mútiples_terciario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            /*float ValorCompra = 0;
            float Descuento = 0;
            char DiaSemana = ' ';

            Console.WriteLine("Ingrese el valor inicial de la compra");
            ValorCompra = Single.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese el día de la semana; l: Lunes, m: Martes, x. Miércoles, j: Jueves, v: Viernes, s: Sábado, d:Domingo");
            DiaSemana = Convert.ToChar(Console.ReadLine());

            switch (DiaSemana) //Palabra reservada para condicionales múltiples- variable que se "evalúa"
            {
                case 'l':
                    Descuento = ValorCompra * 0.1f; //float siempre lleva la f al final
                    Console.WriteLine($"Hoy el Lunes, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                case 'm':
                    Descuento = ValorCompra * 0.15f; 
                    Console.WriteLine($"Hoy el Martes, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                case 'x':
                    Descuento = ValorCompra * 0.1f;
                    Console.WriteLine($"Hoy el Miércoles, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                case 'j':
                    Descuento = ValorCompra * 0.15f;
                    Console.WriteLine($"Hoy el Jueves, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                case 'v':
                    Descuento = ValorCompra * 0.2f;
                    Console.WriteLine($"Hoy el Viernes, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                case 's':
                    Descuento = ValorCompra * 0.2f;
                    Console.WriteLine($"Hoy el Sábado, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                case 'd':
                    Descuento = 0;
                    Console.WriteLine($"Hoy el Domingo, descuento de{Descuento}, el valor total de su compra es{ValorCompra - Descuento}");
                    break;
                default://Se pone en caso de que el usuario ingrese cualquier otra cosa que no se encuentre entre los casos
                    Console.WriteLine("Debe ingresar un día de la semana válido");
                    break;*/

            //Ejercicio 2 Diseñar un algoritmo que permita crear una calculadora básica capaz de realizar operaciones aritméticas entre dos números ingresados por el usuario. Las operaciones disponibles serán: suma, resta, multiplicación y división, las cuales se ejecutarán según la opción seleccionada por el usuario.

            float num1 = 0;
            float num2 = 0;
            char opcion = ' ';

            Console.WriteLine("Ingrese el número 1");
            num1= Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2");
            num2 = Convert.ToSingle(Console.ReadLine());

            Console.WriteLine("Ingrese el tipo de operacion que desea realizar; s: Suma, r: Resta, m: Multiplicación, d: División");
            opcion = Convert.ToChar(Console.ReadLine());

            switch (opcion) 
            {
                case 's':
                    Console.WriteLine($"El resultado es {num1}+{num2} = {num1 + num2}");
                    break;
                case 'r':
                    Console.WriteLine($"El resultado es {num1}-{num2} = {num1 - num2}");
                    break;
                case 'm':
                    Console.WriteLine($"El resultado es {num1}*{num2} = {num1 * num2}");
                    break;
                case 'd':
                    Console.WriteLine($"El resultado es {num1}/{num2} = {num1 / num2}");
                    break;
                default:
                    Console.WriteLine("Por favor, ingrese una operación válida");
                    break;
            }
        }
    }
}
