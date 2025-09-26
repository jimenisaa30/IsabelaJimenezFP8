namespace _27._Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaración de matrices
            int[,] numeros = new int[2,2];
            string[,] nombres = new string[2,3];
            char[,] caracteres = new char[3,2];

            //Ingresar datos

            numeros[0, 0] = 20;
            numeros[0, 1] = 35;
            numeros[1, 0] = 42;
            numeros[1, 1] = 78;

            //Otra forma de declarar e inicalizar matrices
            /* string[,] apellidos =
             {
                 {"Jiménez","Cardona" },
                 {"Buitrago", "Arias"},
                 {"Acevedo" , "Ortiz" }
             };

             //Recuperar datos de la matriz
             Console.WriteLine(apellidos[1, 1]);

             //Recorres matrices
             for(int i = 0; i < 3; i++)//Recorre las filas
             {
                 for(int j = 0;j < 2; j++)//Recorre las columnas en cada una de la filas
                 {
                     Console.WriteLine($"Ingrese el caracter para la posición con índices{i}, {j}");
                     caracteres[i,j] = char.Parse(Console.ReadLine());
                 }
             }

             //Recorrer matrices para recuperar datos
             for(int i = 0;i < caracteres.GetLength(0); i++) //.GetLenght con 0 devuelve el número de filas
             {
                 for (int j = 0; j < caracteres.GetLength(1); j++) //Con 1 devuelve el número de columnas
                 {
                     Console.WriteLine ($"Caracter posición {i},{j}: {caracteres[i,j]}");
                 }
                 Console.WriteLine();
             }

             //Rango de la matriz
             Console.WriteLine(caracteres.Length);*/

            //EJERCICIO
            int[,] numDiez =
            {
                { 10,10,10,10 },
                { 10,10,10,10 },
                { 10,10,10,10 },
                { 10,10,10,10 }
            };

            for (int i = 0; i < numDiez.GetLength(0); i++) //.GetLenght con 0 devuelve el número de filas
            {
                for (int j = 0; j < numDiez.GetLength(1); j++) //Con 1 devuelve el número de columnas
                {
                    Console.WriteLine($"Caracter posición {i},{j}: {numDiez[i, j]}");
                }
                
                Console.WriteLine();
            }

        } 
    }
}
