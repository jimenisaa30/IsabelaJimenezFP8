namespace _23._Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int[5]; //Los vectores los tratamos como si fueran variables normales / tiene 5 posiciones
            string[] nombres = new string[4];

            //Asignar valores a las posiciones
            numeros[0] = 20;
            numeros[1] = 15;
            numeros[2] = 5;
            numeros[3] = 30;
            numeros[4] = 45;
            //numeros[5] = 85; error porque el indice 5 no existe

            int[] numeros2 = new int[] { 5, 12, 4, 7, 9, 21 };
            int[] numeros3 = { 5, 12, 4, 7, 9, 21 };  //Otras formas de almacenar los datos en vectores

            //Se puede recorrer el vector para llenarlo de datos o para recuperar los datos
            //para recorrer el vector lo más óptimo el usar un for porque ya se sabe la cantidad de datos que debe almacenar

            char[] caracter = new char[4];

            /*
            for (int i = 0; i < 4; i++) //Recorre para ingresar los datos
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i+1} con índice {i}:");
                caracter[i]= Convert.ToChar(Console.ReadLine());
            }

            Console.WriteLine($"El vector caracter, en la posición 3, tiene el dato {caracter[2]} en la posición 3");

            for (int i = 0; i < 4; i++)//recorre para leer los datos
            {
                Console.WriteLine($"El vector caracter, en la posición {i+1}, tiene el dato {caracter[i]} en la posición 3");
            }

            for (int i = 0;i < caracter.Length; i++) //Length devuelve el rango del vector
            {
                Console.Write(caracter[i]+" | ");
            }*/

            
            //Para la variable string nombres
            for(int i = 0; i<4 ; i++)
            {
                Console.WriteLine($"Ingrese el nombre para la posición {i + 1} con índice {i}:");
                nombres[i] = Console.ReadLine();
            }
            for (int i = 0; i < nombres.Length; i++) //Length devuelve el rango del vector
            {
                Console.Write(nombres[i] + " | ");
            }

        }
    }
}
