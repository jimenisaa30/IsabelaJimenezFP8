namespace _7._Operador_Ternario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Operador ternario
            //Escribe un programa que verifique si una persona es mayor de edad usando el operador ternario. Una persona mayor de edad tiene 18 años o más)

            int edad = 0;
            Console.WriteLine("Ingrese su edad");
            edad=Int32.Parse(Console.ReadLine()); // Otra manera de convertir datos para poder leer

            Console.WriteLine(edad >= 18 ? "La persona es mayor de edad" : "La persona no es mayor de edad");

            //Crear algoritmo que permita ingresar tres números enteros y mostrar en pantalla cuál es el mayor

            int num1 = 0;
            int num2 = 0;
            int num3 = 0;
            int mayor = 0;

            Console.WriteLine("Ingrese el primer número");
            num1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número");
            num2 = Int32.Parse(Console.ReadLine()); 
            Console.WriteLine("Ingrese el tercer número");
            num3 = Int32.Parse(Console.ReadLine());

            mayor = num1> num2 
                ? (num1>num3 ?num1 : num3) // si la primera condición es verdadera
                : (num2 > num3 ? num2 :num3); /// si la primera condición es falsa
            Console.WriteLine($"El número mayor el {mayor}");
        }
    }
}
