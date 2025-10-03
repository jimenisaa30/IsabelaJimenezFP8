namespace _30._Taller_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ejercicio1 : Desarrollar un programa que crea una matriz de 10 filas y 20 columnas y muestre por
            pantalla la suma de los elementos de cada columna.*/

            /*
            int[,] numeros = new int[4,4];
            int[] sumaColumnas = new int[numeros.GetLength(1)]; //El rango del vector depende de las columnas de la matriz

            for (int i = 0; i < numeros.GetLength(0); i++) //Recordando que getlength es para pedirle al usuario los datos
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el numero para la posición {i},{j}");
                    numeros[i,j]=int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < numeros.GetLength(0); i++) //Mostrar la matriz
            {
                for (int j = 0; j < numeros.GetLength(1); j++)
                {
                    Console.Write($"{numeros[i,j]} | ");
                }
                Console.WriteLine();
            }

            for(int i = 0;i < numeros.GetLength(1); i++)//Recorrer la matriz para sumar las columnas
            {
                for (int j = 0; j < numeros.GetLength(0); j++)
                {
                    sumaColumnas[i] += numeros[j,i];   
                }
            }

            for ( int i = 0;i< sumaColumnas.Length ; i++) //Recorrer el vector para mostrarlo
            {
                Console.Write($"{sumaColumnas[i]} |");
            }*/


            /*Ejercicio2: Desarrollar un programa que crea una matriz de n filas * m columnas, el usuario ingresa
                caracteres en cada posición de la matriz hasta llenarla. El programa debe intercambiar la
                primera fila con la última fila de la matriz. Al final se debe imprimir la matriz original, y la
                matriz con el intercambio de filas.*/

            char[,] caracteres = new char[3,3];

            
            //Recorrer la matriz para llenarla
            for (int i = 0; i < caracteres.GetLength(0); i++) 
            {
                for (int j = 0; j < caracteres.GetLength(1); j++)
                {
                    Console.WriteLine($"Ingrese el caracter para la posición {i},{j}");
                    caracteres[i, j] = char.Parse(Console.ReadLine());
                }
            }

            //Recorrer la matriz para mostrarla
            for (int i = 0;i < caracteres.GetLength(0); i++)
            {
                for(int j = 0; j < caracteres.GetLength(1); j++)
                {
                    Console.Write($"{caracteres[i, j]} | ");
                }
                Console.WriteLine();
            }

            for (int j = 0; j <caracteres.GetLength(1); j++)
            {
                char 
            }
        }
    }
}
