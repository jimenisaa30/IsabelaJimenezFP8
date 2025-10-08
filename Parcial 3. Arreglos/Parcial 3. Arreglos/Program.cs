using System.Security.Cryptography;

namespace Parcial_3._Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[,] matriz = new string[6, 6];
            matriz[0, 0] = "nombre del estudiante";
                    matriz[0, 1] = "Grado";
                    matriz[0, 2] = "Nota parcial 1";
                    matriz[0, 3] = "Nota parcial 2";
                    matriz[0, 4] = "Nota examen final";
                    matriz[0, 5] = "Nota final";
            string gradosPermitidos = "6"+ "7"+"8"+ "9";
            int MayorNotaFinal = -1;
            string EstMayorNota = " ";

            for(int i = 0; i < matriz.Length; i++)//LLenar
            {
                Console.WriteLine("Ingrese el nombre del estudiante");
                matriz[i, 0] = (Console.ReadLine());

                Console.WriteLine("Ingrese el grado del estudiante");
                matriz[i, 1] = (Console.ReadLine());
                string grado = " ";

                if (grado != gradosPermitidos)
                {
                    Console.WriteLine("Recuerde que solo puede ingresar los grados entre 6° y 9°, intente de nuevo");
                }
                matriz[i, 1] = grado.ToString();

                Console.WriteLine("Ingrese la nota del parcial 1");
                matriz[i, 2] = (Console.ReadLine());
                int NotaParcial1 = 0;
                if (NotaParcial1 < 0 && NotaParcial1 > 5)
                {
                    Console.WriteLine("Ingrese la nota de nuevo, recuerde que solo se permiten notas de 0 a 5");
                }

                matriz[i, 2] = NotaParcial1.ToString();


                Console.WriteLine("Ingrese la nota del parcial 2");
                matriz[i, 3] = (Console.ReadLine());
                int NotaParcial2 = 0;
                if (NotaParcial2 < 0 && NotaParcial2 > 5)
                {
                    Console.WriteLine("Ingrese la nota de nuevo, recuerde que solo se permiten notas de 0 a 5");
                }

                matriz[i, 3] = NotaParcial2.ToString();

                Console.WriteLine("Ingrese la nota del parcial final");
                matriz[i, 4] = (Console.ReadLine());
                int NotaParcialFinal = 0;
                if (NotaParcialFinal < 0 && NotaParcialFinal > 5)
                {
                    Console.WriteLine("Ingrese la nota de nuevo, recuerde que solo se permiten notas de 0 a 5");
                }

                matriz[i, 4] = NotaParcialFinal.ToString();

                int NotaFinal = (NotaParcial1 + NotaParcial2 + NotaParcialFinal) / 3;
                matriz[i, 5] = NotaFinal.ToString();

                if (NotaFinal > MayorNotaFinal)
                {
                    NotaFinal = MayorNotaFinal;
                    EstMayorNota = matriz[i, 0];
                }

            }

            for (int i = 0; i < matriz.Length; i++)//Mostrar
            {
                for(int j =0; j < matriz.Length; j++)
                {
                    Console.Write(matriz[i,j]);
                }
                Console.WriteLine();
            }

            Console.WriteLine($"El estudiante con la mayor nota final es {EstMayorNota}");

        }
    }
}
