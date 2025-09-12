namespace _19.Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.*/

            int cantAlumnos = 5;
            int Hombres = 0;
            int Mujeres = 0;
            char genero = ' ';
            int Menores = 0;
            int Mayores = 0;
            int edad = 0;

            do
            {
                Console.WriteLine("Ingrese el género del estudiante");
                Console.WriteLine("f: Femenino - m: Masculino");
                genero = Convert.ToChar(Console.ReadLine());

                if (genero == 'f')
                {
                    Mujeres++;
                }
                else if (genero == 'm')
                {
                    Hombres++;
                }

                Console.WriteLine("Ingrese la edad del estudiante");
                if(edad < 18)
                {
                    Menores++;
                }
                else if(edad >= 18)
                {
                    Mayores++;
                }

            } while (cantAlumnos >= 5);

            Console.WriteLine($"En el salón de clases hay {Mujeres} {Mayores} {Menores}");
        }
    }
}
