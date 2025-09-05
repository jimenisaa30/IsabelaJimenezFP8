namespace _17._Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. 

            /*
            int contador = 0; //Inicia cada número entero
            int acumulador = 0; //Va guradando la suma de los números

            do
            {
                contador++;
                acumulador += contador;

            } while (contador <5 );

            Console.WriteLine($"La suma de los primeros 5 números enteros es de {acumulador}");
            */

            /*Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. */

            
            int numero = 0;
            string continuar = " ";

            int contador = 1;

            /*
            FORMA 1 (yo)
            Console.WriteLine("Ingrese un número del 1 al 10 para ver su tabla de multiplicación");
            numero = Convert.ToInt32(Console.ReadLine());

             do
            {
                Console.WriteLine($"{numero} x 1 = {numero * 1}");
                Console.WriteLine($"{numero} x 2 = {numero * 2}");
                Console.WriteLine($"{numero} x 3 = {numero * 3}");
                Console.WriteLine($"{numero} x 4 = {numero * 4}");
                Console.WriteLine($"{numero} x 5 = {numero * 5}");
                Console.WriteLine($"{numero} x 6 = {numero * 6}");
                Console.WriteLine($"{numero} x 7 = {numero * 7}");
                Console.WriteLine($"{numero} x 8 = {numero * 8}");
                Console.WriteLine($"{numero} x 9 = {numero * 9}");
                Console.WriteLine($"{numero} x 10 = {numero * 10}");

                Console.WriteLine("Desea generar otra tabla de multiplicar? Sí: s No: n");
                continuar = Convert.ToChar(Console.ReadLine());

            } while (continuar == 's'); */

            //FORMA 2 (profe)


            do
            {
                Console.WriteLine("Ingrese un número del 1 al 10 para ver su tabla de multiplicación");
                numero = Convert.ToInt32(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;

                } while (contador <= 10);
                
                contador = 1;//Reinicia el contador para evitar errores

                Console.WriteLine("Desea generar otra tabla de multiplicar? Sí: s No: n");
                continuar =Console.ReadLine().ToLower(); //Convierte todo a minúscula en caso de que el usuario ingrese mayúsculas

            } while (continuar == "s"); //Variable bandera (bool, char, números)

            //Podemos generar ciclos anidados pero estos "Complican" el algoritmo lo que hace que requiera más máquina.
            


        }
    }
}
