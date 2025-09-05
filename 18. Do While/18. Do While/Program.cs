namespace _18._Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
                Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
                Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
                El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 

            Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */

            string nombre = " ";
            int NumCuenta = 0;
            float saldo = 0.0f;

            string continuar = " ";

            int NumUsuarios = 0; //Contador
            float PromSaldos = 0.0f;

            do
            {
                Console.WriteLine("Ingrese su nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese su número de cuenta");
                NumCuenta = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingrese su saldo actual");
                saldo = Convert.ToSingle(Console.ReadLine());

                if (saldo >= 3000000f)
                {
                    Console.WriteLine($"El usuario {nombre} con número de cuenta {NumCuenta} y saldo {saldo} es apto para el crédito ");
                }
                else if (saldo <= 3000000f)
                {
                    Console.WriteLine($"El usuario {nombre} con número de cuenta {NumCuenta} y saldo {saldo} no es apto para el crédito ");
                }

                NumUsuarios++;
                Console.WriteLine($"El número de usuarios encuestados es {NumUsuarios}");

                PromSaldos += saldo / NumUsuarios;
                Console.WriteLine(PromSaldos);

                Console.WriteLine("Desea ingresar más información sobre los usuarios? Sí: s - No: n");
                continuar = Console.ReadLine().ToLower();

            } while (continuar == "s");
        }
    }
}
