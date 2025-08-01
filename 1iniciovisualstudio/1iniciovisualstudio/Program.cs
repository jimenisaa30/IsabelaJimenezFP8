namespace _1iniciovisualstudio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declaración e inicialización de variables
            string nombre= "Isabela";
            const string iva = "19%";
            string apellidos = "Jiménez López";

            Console.WriteLine(nombre + ", Bienvenido a Fundamentos de programación");
            nombre = "Alejandro";// como la variable nombre no es constante l apuedo cambiar incluso después de inicializarlo
            // iva = "20%";No puedo cambiar el valor de la variable iva por ser una constante
            Console.Write("\t"+ nombre +" "+ apellidos +" "+ iva);
            Console.ReadKey(); // Para que el usuario toque cualquier tecla y el programa se termine de ejecutar
        }
    }
}
