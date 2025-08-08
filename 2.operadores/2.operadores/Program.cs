namespace _2.operadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //OPERADORES
            //Operadores numéricos
            //Cambio de signo

            int numero1 = 5;
            int numero2 = -numero1;
            int numero3 = +numero2; //Funciona como la ley de signos en matemáticas
            int numero4 = -numero3;

            Console.WriteLine(numero1 + "//" + numero2 + "//" + numero3 + "//" + numero4);

            //Operadores aritméticos
            int numero5 = 3 + 5;  //suma
            Console.WriteLine(numero5);

            int numero6 = 100 - 26;  //resta
            Console.WriteLine(numero6);

            int numero7 = 4 * 2;  //Producto
            Console.WriteLine(numero7);

            //float numero8 = (float) 5/3 ;  Cociente/ castear para expresar el resultado en la variable que es
            //float num8 = 5f/3;             acá estoy diciendo que el 5 es un float

            float numero8 = 5 / 3f;      //otra manera para mantener el tipo de variable
            Console.WriteLine(numero8);

            double numero9 = 105d / 4;
            Console.WriteLine(numero9);

            decimal numero10 = 50m / 6;  //es el tipo de variable que almacena la mayor cantidad de datos entonces, es más preciso
            Console.WriteLine(numero10);
            
            numero10++;  //numero10 = numero10+1; incremento
            Console.WriteLine(numero10);
            numero1--;  //numero1 = numero1 - 1;
            Console.WriteLine(numero1);

            numero2 += 5;  //operador de aignación numero2= numero2 + 5;
            Console.WriteLine(numero2);

            numero3 -= 5; //numero3 = numero3 - 5;
            Console.WriteLine(numero3);

            numero4 *= 5;  // numero4 = numero4 * 5;
            Console.WriteLine(numero4);

            numero5 /=numero1;  //numero5 = numero5/numero1;
            Console.WriteLine(numero5);

            //Orden de evaluación de los operadores aritméticos
            float numero11 = 4f * 3 / 2;
            Console.WriteLine(numero11);
            
            float numero12 = 4 / 3 * 2f;
            Console.WriteLine(numero12);
            
            float numero13 = (4 * 3) / 2;
            Console.WriteLine(numero13);
            
            float numero14 = 4 * 6 * 2;
            Console.WriteLine(numero14);
            
            float numero15 = 4 + 6 +(2 - 12);
            Console.WriteLine(numero15);

            //Operadores lógicos
            //Conjunción - AND - Y - &&
            Console.WriteLine("Tabla de verdad conjunción");
            Console.WriteLine($"V && V {true && true}");
            Console.WriteLine($"V && F {true && false}");
            Console.WriteLine($"F && V {false && true}");
            Console.WriteLine($"F && F {false && false}");

            //Disyunción - OR - ||
            Console.WriteLine("Tabla de verdad disyunción");
            Console.WriteLine($"V || V {true && true}");
            Console.WriteLine($"V || F {true && false}");
            Console.WriteLine($"F || V {false && true}");
            Console.WriteLine($"F || F {false && false}");

            bool exp1 = true;
            bool exp2 = false;
            bool exp3 = exp1 && exp2; //false
            bool exp4 = !exp2; //true
            bool exp5 = !exp3 || exp4; // true
            Console.WriteLine($"exp1= {exp1}, exp2= {exp2}, exp3 = {exp3}, exp4= {exp4}, exp5= {exp5}");

            //Operadores de comparación
            bool exp6 = 5 > 5;  //true, false
            Console.WriteLine (exp6);

            bool exp7 = 6 == 6;  //Operador de igualdad
            Console.WriteLine(exp7);

            bool exp8 = 4 != 5; //Operador de diferencia
            Console.WriteLine( exp8 );

            bool exp9 = 5 > 4 && 6 != 6; //Operadores de comparación y diferencia
            Console.WriteLine(exp9);

            bool exp10 = 10 > 9 || !exp9;
            Console.WriteLine(exp10);
        }
    }
}
