using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutaja sünniaastat
            //programm kontrollib kasutaja vanust
            //programm teatab kaasutajat, kas ta on piisavalt vana,
            //et juhiluba saada (tingimuseks 18 aastat vana)
            Console.WriteLine("Sisesta oma sünniaasta:");
            int YearOfBirth = Convert.ToInt32(Console.ReadLine());
            int Age = 2021 - YearOfBirth;
            if (Age > 18)
            {
                Console.WriteLine("Sa võid juhilube teha.");
            }
            else if (Age < 18)
            {
                Console.WriteLine("Sa ei või juhilube teha.");
            }
        }
    }
}
