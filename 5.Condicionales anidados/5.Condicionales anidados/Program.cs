namespace _5.Condicionales_anidados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Ejercicio 1. 
            
            int num1 = 0;
            int num2 = 0;
            int num3 = 0;

            Console.WriteLine("Ingrese el número 1:");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número 2:");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese el número 3:");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > num2)
            {
                if (num1 > num3)
                {
                    Console.WriteLine($"El número 1 {num1} es el mayor.");
                }
                else 
                {
                    Console.WriteLine($"El número 3 {num3} es el mayor.");

                }
            }
            else 
            {
                if (num2 > num3)
                {
                    Console.WriteLine($"El número 2 {num2} es el mayor.");
                }
                else
                {
                    Console.WriteLine($"El número 3 {num3} es el mayor.");

                }
            }
        }
    }
}
