namespace _10._Ciclo_while_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Crear un algoritmo que permita calcular la factorial de un número  dado por el usuario.

            int numero = 0;
            int contador = 1;
            int acumulador = 1;

            Console.WriteLine("Ingrese un número para calcular su factorial");
            numero = Convert.ToInt32(Console.ReadLine());

            while (contador <= numero)
            {
                acumulador *= contador;
                contador++;
            }
            Console.WriteLine(acumulador);
        }
    }
}
