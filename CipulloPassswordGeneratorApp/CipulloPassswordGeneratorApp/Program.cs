using System;

namespace CipulloPassswordGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Generatore di password");

            int[] numeri = new int[10];
            numeri[0] = 1;
            numeri[1] = 2; 
            numeri[2] = 3; 
            numeri[3] = 4;
            numeri[4] = 5;
            numeri[5] = 6; 
            numeri[6] = 7; 
            numeri[7] = 8; 
            numeri[8] = 9;
            numeri[9] = 0;

            char[] alfabeto = new char[26];

            alfabeto[0] = 'a';
            alfabeto[1] = 'b';
            alfabeto[2] = 'c';
            alfabeto[3] = 'd';
            alfabeto[4] = 'e';
            alfabeto[5] = 'f';
            alfabeto[6] = 'g';
            alfabeto[7] = 'h';
            alfabeto[8] = 'i';
            alfabeto[9] = 'j';
            alfabeto[10] ='k';
            alfabeto[11] ='l';
            alfabeto[12] ='m';
            alfabeto[13] = 'n';
            alfabeto[14] = 'o';
            alfabeto[15] = 'p';
            alfabeto[16] = 'q';
            alfabeto[17] = 'r';
            alfabeto[18] = 's';
            alfabeto[19] = 't';
            alfabeto[20] = 'u';
            alfabeto[21] = 'v';
            alfabeto[22] = 'w';
            alfabeto[23] = 'x';
            alfabeto[24] = 'y';
            alfabeto[25] = 'z';

            Console.WriteLine("indica la lunghezza della tua password");
            int lunghezza = Convert.ToInt32(Console.ReadLine());

            string nuovaPassword = "";
            Random generatore = new Random();

            for (int i = 0; i <= lunghezza; i++)
            {
                int indiceCasuale = generatore.Next(1,26);
                nuovaPassword = nuovaPassword + alfabeto[indiceCasuale];
            }
            Console.WriteLine("La tua password é:");
            Console.WriteLine(nuovaPassword);
        }
    }
}
