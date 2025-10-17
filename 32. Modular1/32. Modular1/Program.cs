namespace _32._Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] multiplos5 = new int[CapturarFilas(), CapturarColumnas()];
            LlenarMatriz(multiplos5); //Hace la función con un parámetro
            MostrarMatriz(multiplos5);
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        static void MostrarMatriz(int[,] matriz) //Procedimiento que recibe la matriz mostrar
        {
            BorrarPantalla();

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++)
                {
                    Console.Write(matriz[i, j] + "|");
                }
                Console.WriteLine();
            }
        }
        static int[,] LlenarMatriz(int[,] matriz) //Función
        {
            int numero = 0;

            for (int i = 0; i < matriz.GetLength(0); i++)
            {
                for (int j = 0; j < matriz.GetLength(1); j++) //Ciclo principal para llenar la matriz
                {
                    do //Ciclo especifico para comprobar las condiciones del algoritmo
                    {
                        BorrarPantalla();

                        Console.WriteLine("Digite un número para ingresar a la matriz");
                        numero = int.Parse(Console.ReadLine());
                    } while (EsMultiplo5(numero) == false);

                    matriz[i, j] = numero; //Después de comprobar la condición se pueden almacenar lo números en la matriz

                }
            }

            return matriz;
        }

        static bool EsMultiplo5(int numero) //El parámetro se "Declara" como una variable normal
        {
            if (numero % 5 == 0 && numero != 0) //Todos los caminos que uno genere con un if debe tener un return
            {
                return true;
            }
            else
            {
                Console.WriteLine("Error, debe ingresar un número múltiplo de 5");

                return false;
            }
        }


        static int CapturarFilas() //Función
        {
            Console.WriteLine("Ingrese el número de filas para la matriz");
            int filas = Convert.ToInt32(Console.ReadLine());
            return filas;
        }

        static int CapturarColumnas() //Función
        {
            Console.WriteLine("Ingrese el número de columnas para la matriz");
            int columnas = Convert.ToInt32(Console.ReadLine());
            return columnas;
        }
    }
}
