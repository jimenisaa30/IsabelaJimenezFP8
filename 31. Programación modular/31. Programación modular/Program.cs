namespace _31._Programación_modular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MostrarMensaje();
            MostrarMensajes("Mi nombre es Isabela");
            //MostrarMensajes("Tengo 18 años");
            //Console.WriteLine($"Edad calculada: {CalcularEdad()}");
            MostrarMensajes($"Tengo {CalcularEdad(2025,2007)} años");
        }

        //Modulo 1 - Procedimiento sin parámetros
        static void MostrarMensaje()
        {
            Console.WriteLine("Bienvenidos a la clase de programación modular");
            MostrarMensajes("Estoy desde procedimientos");
        }

        //Modulo 2 - Procedimiento con parámetros
        static void MostrarMensajes(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Módulo 3 - Función
        static int CalcularEdad()
        {
            int edad;
            edad = 2025-2007;

            return edad; //Cuando se trabaja con funciones debe devolver un valor al módulo
        }

        //Módulo 4 - Función con Parámetros
        static int CalcularEdad (int AñoActual, int AñodeNacimiento)
        {
            return AñoActual - AñodeNacimiento;
        }
    }
}
