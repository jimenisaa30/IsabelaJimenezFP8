namespace _28._Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un programa que realice la suma de dos matrices de dimensiones 2x3.
 
                Requisitos del programa:
                Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
                Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2x3).
                Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las dos matrices.
                Muestra la matriz resultante de la suma en formato de matriz (2 filas, 3 columnas).*/

            int[,] matriz1 = new int[2,3];
            int[,] matriz2 = new int[2,3];
            int[,] matrizSuma = new int[2,3];

            for (int i = 0; i < 2; i++)//Recorre la matriz 1
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición con índices{i}, {j} en la matriz #1");
                    matriz1[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)//Recorre la matriz 2
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese el número para la posición con índices{i}, {j} en la matriz #2");
                    matriz2[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    matrizSuma[i, j] = matriz1[i, j] + matriz2[i,j];
                }
            }

            for (int i = 0; i < matrizSuma.GetLength(0); i++) //.GetLenght con 0 devuelve el número de filas
            {
                for (int j = 0; j < matrizSuma.GetLength(1); j++) //Con 1 devuelve el número de columnas
                {
                    Console.WriteLine(matrizSuma[i, j]);
                }
                Console.WriteLine();
            }
        } 
    }
}
