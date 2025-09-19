using System.Runtime.InteropServices;

namespace _22._Taller_ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //TALLER

            /*EJERCICIO 1: Algoritmo que permita calcular el promedio de calificaciones, el algoritmo 
                le permitirá al usuario, introducir tantas calificaciones como así desee, 
                en el momento en que seleccione que no desea continuar capturando 
                calificaciones, el algoritmo debe presentar el promedio de las 
                calificaciones capturadas previamente. 
                */

            /*float calificacion = 0f;
            int numCalf = 0; //Contador para calcular el promedio
            char respuesta = ' '; //Para preguntar al usuario si quiere continuar 

            do
            {
                Console.WriteLine("Ingrese la calificación");
                calificacion = Convert.ToSingle(Console.ReadLine());

                numCalf++;

                Console.WriteLine("¿Desea continuar ingresando calificaciones?");
                Console.WriteLine("s: sí - n:no");

                respuesta = Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');

            calificacion += calificacion;

            Console.WriteLine($"El promedio de calificaciones es de {calificacion/numCalf}");*/

            /*EJERCICIO 2: Se requiere un algoritmo para mostrar por pantalla los divisores de un 
                número ingresado por teclado. 
                Tener en cuenta que dados dos números enteros a y b, se dice que b es 
                divisor de a si se cumple que al efectuar una división entera a/b el 
                residuo es 0, en C# utilizar el operador Mod para obtener el residuo de 
                una división de dos números. 
                Ejemplo: si se ingresa 6 por teclado, por pantalla se debe mostrar 6, 3, 
                2, 1 que son los divisores del número 6. */

            /*int num = 0;

            Console.WriteLine("Ingresa un número para descubrir sus divisores");
            num=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                if(num % i == 0)
                {
                    Console.WriteLine($"Los divisores de {num} son {i}");
                }
                else
                {
                    Console.WriteLine("Entrada no válida, intenta de nuevo");
                }
            }*/


            /*EJERCICIO 3:Dados dos números enteros ingresados por teclado: b que es la base y
                e que es el exponente, se requiere calcular el resultado de la
                potenciación.
                Ejemplo: b=2, e=5  25=2*2*2*2*2= 32
                Mostrar por pantalla el resultado de la potenciación.
                Seguir pidiendo por teclado la base y el exponente y realizar la
                potenciación correspondiente, hasta que el usuario ingrese por teclado
                el carácter de escape ‘n’ */

            /*int numB = 0;
            int numE = 0;
            int resultado = 1; //Esto es  un acumulador y ypara multiplicar tiene que iniciar en 1
            char respuesta = ' ';

            do
            {
                Console.WriteLine("Ingresa la base");
                numB = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa el exponente");
                numE = Convert.ToInt32(Console.ReadLine());

                for(int i =0; i < numE; i++) //a medida que i va aumentando de acuerdo a la condición resultado guarda la multiplicación de la base por ella misma las veces que necesite
                {
                    resultado *= numB;
                }
                Console.WriteLine($"El resultado de la potencia {numE} del número {numB} es {resultado}");

                resultado = 1;

                Console.WriteLine("Deseas continuar? s: sí - n: no");
                respuesta=Convert.ToChar(Console.ReadLine());
            } while (respuesta == 's');*/

            /*EJERCICIO 4: Un entrenador le ha propuesto a un atleta recorrer una ruta de cinco
                kilómetros durante 10 días, para determinar si es apto para la prueba de
                5 kilómetros. Para considerarlo apto debe cumplir las siguientes
                condiciones:
                 Que en ninguna de las pruebas haga un tiempo mayor a 20 minutos.
                 Que al menos en una de las pruebas realice un tiempo menor de 15
                minutos.
                 Que su promedio sea menor o igual a 18 minutos.
                Diseñar un algoritmo para registrar los datos y decidir si es apto para la
                competencia.*/

            float numPruebas = 0f;
            float tiempoPruebas = 0f;
            float prom = 0f;
        }
    }
}
