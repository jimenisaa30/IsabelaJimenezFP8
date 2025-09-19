namespace Parcial_2._Ciclos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*PUNTO PARCIAL: El director de la escuela “Herederos” desea conocer información estadística sobre las edades de los estudiantes del grado quinto A, que cuenta con 15 alumnos.
                El programa debe realizar las siguientes acciones:
                -Ingresar por teclado la edad de cada estudiante (solo se permiten valores de 4, 5 o 6 años).
                -Calcular el promedio de edad del grupo.
                -Contar y mostrar cuántos estudiantes tienen 4 años, cuántos tienen 5 años y cuántos tienen 6 años.
                -Comparar las cantidades y mostrar un mensaje especial:
                -Si el número de estudiantes de 6 años es mayor que el de los demás, mostrar: “Grupo mayor”.
                -Si el número de estudiantes de 4 años es mayor que el de los demás, mostrar: “Grupo menor”.*/

            int edadEstudiantes = 0;
            int cantEstudiantes = 0;
            int sumaEdad = 0;
            int promEdad = 0;
            int cantEdad4 = 0;
            int cantEdad5 = 0;
            int cantEdad6 = 0;

            do
            {
                Console.WriteLine($"Ingrese la edad del estudiante");
                edadEstudiantes=Convert.ToInt32( Console.ReadLine() );

                if(edadEstudiantes != 4 && edadEstudiantes != 5 && edadEstudiantes != 6)
                {
                    Console.WriteLine("El valor ingresado no es válido. Solo se permiten las edades 4, 5 o 6");    
                }

                if(edadEstudiantes == 4)
                {
                    cantEdad4++;
                }
                else if(edadEstudiantes == 5)
                {
                    cantEdad5++;
                }
                else if (edadEstudiantes == 6)
                {
                    cantEdad6++;
                }

                cantEstudiantes++;

                sumaEdad += edadEstudiantes;
            } while (cantEstudiantes <= 15);

            promEdad = sumaEdad / cantEstudiantes;
            Console.WriteLine($"El promedio de las edades de los estudiantes del curso es: {promEdad}. ");

            Console.WriteLine($"Entre los 15 estudiantes, {cantEdad4} tienen 4 años de edad, {cantEdad5} tienen 5 años de edad y {cantEdad6} tienen 6 años de edad.");
            
            if(cantEdad6 > cantEdad5 && cantEdad6 > cantEdad4)
            {
                Console.WriteLine($"El grupo mayor es de los estudiantes de 6 años de edad {cantEdad6}.");
            }
            else if (cantEdad4 > cantEdad5 && cantEdad4 > cantEdad6)
            {
                Console.WriteLine($"El grupo mayor es de los estudiantes de 4 años de edad con {cantEdad4}. ");
            }
        }
    }
}
