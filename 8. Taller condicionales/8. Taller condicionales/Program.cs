using System.Diagnostics;
using System.Timers;

namespace _8._Taller_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Taller conndicionales

            /*Ejercicio #1 Crear un algoritmo que permita leer tres valores y almacenarlos en las variables numero1,
            numero2, numero3 respectivamente.El algoritmo debe comprobar si los números son
            diferentes, si es así, imprimir cual es el número mayor, además ordenar y mostrar en
            pantalla los números de menor a mayor.
            Si hay números iguales, el algoritmo debe mostrar un mensaje indicando que se deben
            ingresar números diferentes.*/

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
            }
              
        }
    }
}
