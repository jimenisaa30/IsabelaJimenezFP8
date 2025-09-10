namespace _20._Do_While
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
                El número de partidos perdidos  
                El número de partidos empatados  
                El número de partidos ganados  
                El porcentaje de partidos perdidos  
                El porcentaje de partidos empatados  
                El porcentaje de partidos ganados*/

            int totalPartidos = 0;
            int perdidos = 0;
            int empatados = 0;
            int ganados = 0;

            char respuesta = ' ';
            int cant = 5;

            do
            {
                Console.WriteLine("Ingresa el resultado del partido de hoy");
                Console.WriteLine("Ganamos: g - Perdimos: p - Empatamos: e");
                respuesta = Convert.ToChar(Console.ReadLine());


                if(respuesta == 'g')
                {
                    ganados++;
                    Console.WriteLine($"Han ganado {(ganados * 100) / 30}% de los partidos jugados hasta el momento");
                }else if(respuesta == 'p')
                {
                    perdidos++;
                    Console.WriteLine($"Han perdido {(perdidos * 100) / 30}% de los partidos jugados hasta el momento");
                }
                else if (respuesta == 'e')
                {
                    empatados++;
                    Console.WriteLine($"Han empatado {(empatados * 100) / 30}% de los partidos jugados hasta el momento");
                }
                
                totalPartidos++; 
            }while(totalPartidos <= 30);
        }
    }
}
