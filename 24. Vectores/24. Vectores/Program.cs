namespace _24._Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO: Crear arreglo llamado "numeros" de 100 elementos asignar el número 10 en cada una de las posiciones del arreglo. Leer el contenido de cada elemento y escribirlo en pantalla.*/

            int[] numeros = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Ingrese el numero para la posición {i + 1} con índice {i}:");
                numeros[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < 10; i++) //Length devuelve el rango del vector
            {
                Console.Write("posicion"+ (i+1) +numeros[i] + " | ");
            }
        }
    }
}
