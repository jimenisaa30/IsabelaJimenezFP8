namespace _16._Ciclo_while_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribe un algoritmo en el que el ordenador elija un número aleatorio entre 1 y 100. El usuario debe adivinar el número, y el programa debe decirle si su intento es demasiado alto, demasiado bajo o correcto. Usa un ciclo while para seguir pidiendo intentos hasta que el usuario adivine el número. */

            int numGenerado;
            Random rnd = new Random();
            numGenerado = rnd.Next(1, 100);

            int numIntento = 0;

            Console.WriteLine("Adivina el número");

            while(numGenerado != numIntento)
            {
                Console.WriteLine("Ingresa tu intento");
                numIntento=Convert.ToInt32(Console.ReadLine());

                if(numIntento > numGenerado)
                {
                    Console.WriteLine("Tu número es muy alto, intenta de nuevo");
                }
                else if(numIntento < numGenerado)
                {
                    Console.WriteLine("Tu número es muy bajo, intenta de nuevo");
                }
                else if (numIntento == numGenerado)
                {
                    Console.WriteLine("Tu intento es correcto, felicitaciones");
                }
            }
        }
    }
}
