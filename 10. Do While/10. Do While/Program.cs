namespace _10._Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.*/

            int edad = 0;
            int genero = ' ';
            int mayorEdad = 0; //Contador mayores de edad
            int menorEdad = 0;  //Contador menores de edad
            int hombres = 0;  //Contador num de hombres
            int mujeres = 0;  //Contador num de mujeres
            int estudiantes = 0; //Contador número total de estudiantes

            int cant = 5;

            do
            {
                Console.WriteLine("Por favor ingresa la edad del estudiante");
                edad = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Ingresa en genero del estudiante");
                Console.WriteLine("1. Hombre    2.Mujer");
                genero = Convert.ToInt32(Console.ReadLine());

                if (edad >= 18)
                {
                    mayorEdad++;
                }
                else
                {
                    menorEdad++;
                }

                if (genero == 1) //Cuando la estruturacondicional solo tiene una instrucción no es necesario construirel bloque con {}
                    hombres++;
                 else
                    mujeres++;

                estudiantes++;

            } while (estudiantes < cant);

            Console.WriteLine($"De los {cant} estudiantes, {mayorEdad} son mayores de edad. {menorEdad} son menores de edad, {hombres} son hombres, {mujeres} son mujeres");
        }
    }
}
