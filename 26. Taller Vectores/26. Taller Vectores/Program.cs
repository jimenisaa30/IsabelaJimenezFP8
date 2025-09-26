namespace _26._Taller_Vectores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*EJERCICIO 1: Escribir un algoritmo que permita llenar un vector[15] con números enteros, y luego
                encuentre y muestre el valor máximo y mínimo de los números ingresados.*/

            /*
            int[] vector;  //Declarar el vector
            vector = new int[15]; //Inicializando

            int mayor=0;
            int menor=0;

            for (int i = 0; i < vector.Length; i++) //Length sirve para referir a los espacios del vector 
            {
                Console.WriteLine($" Ingrese el número entero para la posición {i + 1}, conindice {i}");
                vector[i] = int.Parse(Console.ReadLine());

                if(i == 0)
                {
                    mayor =vector[i];
                    menor =vector[i];
                }
                else if (vector[i] > mayor)
                {
                    mayor = vector[i];
                }
                else if (vector[i] < menor)
                {
                    menor = vector[i];
                }

            }
            Console.Clear();

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + "|");
            }

            Console.WriteLine($"El número mayor es {mayor} y el número menor es {menor}");
            */


            /*EJERCICIO 2: Escribe un algoritmo que permita ingresar caracteres en un vector, y luego invierta el
                orden de los elementos del vector. Se deben mostrar lo dos vectores.*/

            /*
            char[] vector;
            vector = new char[5];

            char[] vectorInvertido;
            vectorInvertido = new char[5];

            for(int i = 0; i < vector.Length; i++) //Llenar el vector normal
            {
                Console.WriteLine($"Ingrese el caracter para la posición {i+1} con índice {i}");
                vector[i] = Convert.ToChar(Console.ReadLine());
            }
            for(int i = 0; i < vectorInvertido.Length; i++)//Hacer el vector invertido
            {
                vectorInvertido[i] = vector[vector.Length - 1 - i]; //Se usa el rango del vector normal, se le resta 1 para volver una posición e i para volver a la primera posición y mostrarla en el orden en el que se devuelve
            }

            for (int i = 0; i < vector.Length; i++) //Mostrar los vectores 
            {
                Console.Write(vector[i] + "|");
                Console.Write(vectorInvertido[i] + "|");
            }
            */


            /*EJERCICIO 3: Crea un algoritmo que llene un vector[20] con números enteros positivos aleatorios entre
                0 y 50. Luego le debe pedir al usuario un número para buscar en el vector. Si encuentra el
                número, se debe mostrar en pantalla: la posición en que se encuentra el número, y el
                vector resaltando el número en un color diferente. Si no se encuentra el número, se debe
                devolver y mostrar -1.*/

            int[] vector;
            vector =new int[20];


        }
    }
}
