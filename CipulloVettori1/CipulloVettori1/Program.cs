using System;

namespace CipulloVettori1
{
    class Program
    {
        static void Main(string[] args)
        {
            const int dimensione = 400;
            int c = 0;
            
            Random generatore = new Random();
            

            for(c=0;c<dimensione;c++)
            {
                int numerocasuale = generatore.Next(1, 100);
                Console.WriteLine($"{numerocasuale}");
            }

            
        }
    }
}
