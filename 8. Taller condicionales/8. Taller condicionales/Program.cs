using System.Diagnostics;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace _8._Taller_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller condicionales

            /*Ejercicio #1 Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

            /*
            float num1 = 0;
            float num2 = 0;
            float num3 = 0;

            float mayor = 0;
            float medio = 0;
            float menor = 0;

            Console.WriteLine("Ingrese el número 1");
            num1 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el número 2");
            num2 = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine("Ingrese el número 3");
            num3 = Convert.ToSingle(Console.ReadLine());

            if (num1 != num2 && num2 != num3 && num1 != num3) 
            {
                if (num1 > num2)
                {
                    if (num1 > num3)
                    {
                        Console.WriteLine($"El número mayor es {num1}");
                        mayor = num1;
                    }
                    else
                    {
                        Console.WriteLine($"El número mayor es {num3}");
                        mayor = num3;
                    }
                }
                else
                {
                    if (num2 > num3)
                    {
                        Console.WriteLine($"El número mayor es {num2}");
                        mayor = num2;
                    }
                    else
                    {
                        Console.WriteLine($"El número mayor es {num3}");
                        mayor = num3;
                    }
                }

                // además organizarlos de menor a mayor
                if (num1 < num2)
                {
                    if (num1 < num3)
                    {
                        menor= num1;
                        
                        if (num3 > num2)
                        {
                            medio = num2;
                        }
                        else
                        {
                            medio= num3;
                        }
                    }
                    else
                    {
                       if (num2 < num3)
                       {
                            menor = num2;
                            medio = num3;
                       }
                       else
                       {
                            menor = num3;
                            medio = num2;
                       }
                    }
                }
                Console.WriteLine($"Los números organizados de menor a mayor son {menor},{medio},{mayor}");
                
            }
            else
            {
                Console.WriteLine("Los números son iguales, debe ingresar números diferentes");
            }*/


            /*Ejercicio #2 El personaje de un juego puede disparar si cumple con las dos siguientes condiciones: si
            cuenta con munición y si se encuentra en estado invencible, crear un programa que:
                a. Permita ingresar por teclado si el personaje está en estado invencible (True).
                b. La cantidad de munición que tiene el personaje en el momento será calculada por el
            sistema por medio de un número aleatorio, para ello utilizar la clase Random de C#.
            Ejemplo:
            int numero;
            Random rnd = new Random();
            numero = rnd.Next(1, 6);//Devuelve un número entre 0 y 5
            Console.WriteLine(numero);
                c. Si el estado del personaje es invencible (true) y su cantidad de munición está entre 1 y
            10, mostrar un mensaje en la consola “El personaje está disparando”, en caso contrario
            no hacer nada.*/

            /*
            bool invencible = true;
            
            int municion;
            Random rnd = new Random();
            municion = rnd.Next(1, 10);
            

            Console.WriteLine("¿Quieres que tu personaje sea invencible? sí: true/ no:false");
            invencible = Convert.ToBoolean(Console.ReadLine());

            if (invencible == true && municion >= 1 && municion <= 10)
            {
                Console.WriteLine($"Su personaje está disparando. La munición de su personaje es de {municion} además es invencible");
            }
            else if(invencible == false && municion < 1)
            {
                Console.WriteLine($"No puedes disparar. La munición de su personaje es de {municion} además no es invencible");
            }
            */

            /*Ejercicio 3 Crear un algoritmo que permita ingresar las coordenadas x,y, para tres puntos: P1(x1,y1),
            P2(x2,y2), P3(x3,y3). Luego calcular la distancia entre los puntos P1  P2, P2  P3, P1
            P3. La distancia entre dos puntos está dada por la siguiente formula:
            d = √((x2 - x1)² + (y2 - y1)²)
            Después de haber calculado la distancia entre los puntos, el algoritmo debe decir si con
            dichas distancias se puede construir un triángulo, consultar las condiciones que se deben
            cumplir para realizar dicha construcción. En caso contrario, decir cuál o cuáles de las
            condiciones no se cumplen.*/

            /*
            //PUNTO 1
            int x1 = 0;
            int y1 = 0;

            //PUNTO 2
            int x2 = 0;
            int y2 = 0;

            //PUNTO 3
            int x3 = 0;
            int y3 = 0;

            Console.WriteLine("Ingresa las coordenadas (x,y) para el punto 1");
                Console.WriteLine("Coordenada x1");
                x1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coordenada y1");
                y1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa las coordenadas (x,y) para el punto 2");
                Console.WriteLine("Coordenada x2");
                x2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coordenada y2");
                y2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingresa las coordenadas (x,y) para el punto 3");
                Console.WriteLine("Coordenada x3");
                x3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Coordenada y3");
                y3 = Convert.ToInt32(Console.ReadLine());

            //DISTANCIAS PUNTO A PUNTO
            int distanciaP1 = Convert.ToInt32(Math.Sqrt(Math.Pow((x2 - x1),2) + Math.Pow((y2 - y1),2)));
            int distanciaP2 = Convert.ToInt32(Math.Sqrt(Math.Pow((x3 - x1), 2) + Math.Pow((y3 - y1), 2)));
            int distanciaP3 = Convert.ToInt32(Math.Sqrt(Math.Pow((x3 - x2), 2) + Math.Pow((y3 - y2), 2)));


            if ((distanciaP1 + distanciaP2) > distanciaP3)
            {
                Console.WriteLine("Puedes construir un triángulo con estas coordenadas");
            }
            else if ((distanciaP1 + distanciaP3) > distanciaP2)
            {
                Console.WriteLine("Puedes construir un triángulo con estas coordenadas");
            }
            else if ((distanciaP2 + distanciaP3) > distanciaP1)
            {
                Console.WriteLine("Puedes construir un triángulo con estas coordenadas");
            }
            else
            {
                Console.WriteLine("Intenta de nuevo, los puntos no cumplen la condición para construir un triángulo");
            }*/

            /*Ejercicio 4 El personaje de un juego, solo se puede mover en forma horizontal (Izquierda o Derecha),
            crear un programa que muestre en la consola un mensaje diciendo si el personaje se mueve
            hacia la izquierda o hacia la derecha, según la tecla que se presione en el teclado.
             Si se ingresa el carácter ‘d’, se muestra el mensaje “El personaje se mueve hacia la
            derecha"
             Si se ingresa el carácter ‘i’, se muestra el mensaje “El personaje se mueve hacia la derecha"
             En caso contrario, se debe mostrar un mensaje de error “No me puedo mover en otra
            dirección”*/

            /*
            char direccion = ' ';

            Console.WriteLine("Ingresa el carácter 'd' si quieres que tu personaje se mueva hacia la derecha o el carácter 'i' si quieres que se mueva hacia la izquierda");
            direccion = Convert.ToChar(Console.ReadLine());

            if (direccion == 'd')
            {
                Console.WriteLine("El personaje se mueve hacia la derecha");
            }
            else if (direccion == 'i')
            {
                Console.WriteLine("El personaje se mueve a la izquierda");
            }
            else
            {
                Console.WriteLine("El personaje no se puede mover");
            }
            */

            /*Ejercicio 5 El personaje de un juego, puede realizar diferentes acciones dependiendo del carácter que
            el usuario ingrese, y de la cantidad de vidas que posee. Crear un programa que permita:
             Generar un número aleatorio entre 0 y 5 para simular el número de vidas del personaje.
            (Función Random)
             Si el número de vidas es mayor a 0, el personaje puede realizar acciones en el juego. En
            caso contrario escribir el mensaje “el personaje no posee vidas, y no puede realizar
            ninguna acción”.
             Si el personaje puede realizar acciones, escribir los siguientes mensajes de acuerdo al
            carácter que se ingrese:
            o Si se ingresa ‘c’, mostrar en consola “el personaje está disparando”
            o Si se ingresa ‘x’, mostrar en consola “el personaje está hablando con la Rana”
            o Si se ingresa ‘t’, mostrar en consola “el personaje está en modo Turbo”
            o Si se presiona ‘i’, mostrar en consola “el personaje es Invencible”*/

            int vidas;
            Random rnd = new Random();
            vidas = rnd.Next(0,5);

            char accion = ' ';

            Console.WriteLine($"El personaje tiene {vidas} puntos de vida");

            if (vidas > 0)
            {
                Console.WriteLine("Para realizar una acción presiona uno de los siquientes comandos");
                Console.WriteLine("----------------- c para disparar -------------");
                Console.WriteLine("--------- x para hablar con la rana -----------");
                Console.WriteLine("-------- t para activar el modo Turbo ---------");
                Console.WriteLine("------------ i para ser Invencible ------------");
                accion= Convert.ToChar(Console.ReadLine());
                

                switch (accion)
                {
                    case 'c':
                        Console.WriteLine("El personaje está disparando");
                        break;
                    case 'x':
                        Console.WriteLine("El personaje está hablando con la rana");
                        break;
                    case 't':
                        Console.WriteLine("El personaje está en modo Turbo");
                        break;
                    case 'i':
                        Console.WriteLine("El personaje es Invencible");
                        break;
                    default:
                        Console.WriteLine("El personaje no está haciendo nada Intenta de nuevo");
                        break;
                }
            }
            else
            {
                Console.WriteLine("El personaje no posee vidas y no puede realizar ninguna acción");
            }
        }
    }
}
