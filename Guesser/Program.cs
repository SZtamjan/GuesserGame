using System;

namespace MatiApps
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int a = random.Next(1, 101);
            int usr;
            do
            {
                Console.WriteLine("Wpisz liczbę");
                usr = Convert.ToInt32(Console.ReadLine());
                if (usr > a)
                {
                    Console.WriteLine("Liczba jest za duża");
                }
                else if (usr < a)
                {
                    Console.WriteLine("Liczba jest za mała");
                }
            } while (a != usr);
            Console.WriteLine("Brawo, zgadłeś!");

        }
    }
}