namespace _13._Ciclo_while_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar. Al usuario le corresponde
             ingresar la cantidad de números que va a introducir.  
            El algoritmo debe escribir en pantalla: 
            La cantidad de números introducidos que son mayores que 0 
            La cantidad de números introducidos menores que 0  
            La cantidad de números iguales a 0.*/

            int numero = 0;
            int cantidad = 0;

            int contador = 0;
            int mayores0 = 0;
            int menores0 = 0;
            int iguales0 = 0;

            Console.WriteLine("Ingrese la cantidad de números que desea introducir");
            cantidad = Convert.ToInt32(Console.ReadLine());

            while (cantidad < contador )
            {
                Console.WriteLine($"Ingrese el numero {contador + 1}");
                numero = Convert.ToInt32(Console.ReadLine());

                if (numero > 0)
                {
                    Console.Writeline($"{mayores0++}");
                }
                else if (numero < 0)
                {
                    Console.Writeline($"{menores0++}");
                }
                else if (numero == 0)
                {
                    Console.Writeline($"{iguales0++}");
                }
            }
                
        }
    }
}
