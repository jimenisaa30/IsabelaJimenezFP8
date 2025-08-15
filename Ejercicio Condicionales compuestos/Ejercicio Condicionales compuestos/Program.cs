namespace Ejercicio_Condicionales_compuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Ejercicio

            string nombreus = "";
            int precionoche = 200;
            int cantnoches = 0;

            Console.WriteLine("Ingrese el nombre del usuario.");
            nombreus=Console.ReadLine();

            Console.WriteLine($"Ingrese la cantidad de noches que se ha quedado el usuario {nombreus}.");
            cantnoches=Convert.ToInt32(Console.ReadLine());

            if (cantnoches > 3)
            {
                Console.WriteLine($"El usuario {nombreus} debe pagar un total de {(cantnoches*precionoche) - ((cantnoches*precionoche)/100)*17} ya que cuenta con un descuento del 17%.");
            }
            else
            {
                Console.WriteLine($"El usuario {nombreus} debe pagar un total de {(cantnoches * precionoche) - ((cantnoches * precionoche) / 100) * 2} ya que cuenta con un descuento del 2%.");
            }
        }
    }
}
