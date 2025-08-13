namespace _4.CondicionalesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1
            /*int sueldo = 0;
            String nombre = "";
            
            Console.WriteLine("Ingrese su nombre.");
            nombre = Console.ReadLine();

            Console.WriteLine("Ingrese su sueldo mensual.");
            sueldo=Int32.Parse(Console.ReadLine()); //Método para convertir la lectura de caracteres a entero

            if (sueldo >= 3000) 
            {
                //Verdadera
                Console.WriteLine($"La persona {nombre} debe abonar impuestos.");
            }
            else
            {
                //Falsa
                Console.WriteLine($"La persona {nombre} está exenta de abonar impuestos.");
            }*/


            //Ejercicio 2 Crea un algoritmo que lea la edad de un usuario, si el usuario es mayor de 18, se debe mostrar el siguiente mensaje: “Bienvenido a mi sitio web”. De lo contrario, mostra el mensaje "No es apto para le contando de este sitio web"
            /*int edad = 0;

            Console.WriteLine("Ingrese su edad");
            edad = Convert.ToInt32(Console.ReadLine());

            if (edad >= 18)
            {
                Console.WriteLine("Bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No es apto para le contando de este sitio web");
            }*/


            //Ejercicio 3 Crear un algoritmo que permita ingresar dos números si el primer número es mayor al segundo informar su suma y diferencia, en caso contrario informar el producto y la división del primer número respecto al segundo número
            float num1 = 0;
            float num2 = 0;

            Console.WriteLine("Ingrese el primer número");
            num1 = Convert.ToSingle(Console.ReadLine()); // Función para leer el Float

            Console.WriteLine("Ingrese el segundo número");
            num2 = Convert.ToSingle(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"El reultado es {num1 + num2}");
            }
            else
            {
                Console.WriteLine($"El resultado es {num1*num2} y {num1/num2}");    
            }
        }
    }
}
