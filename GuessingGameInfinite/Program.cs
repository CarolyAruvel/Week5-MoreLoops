using System;

namespace GuessingGameInfinite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //programm genereerib juhuslikku numbrit 1 kuni 10 
            //kasutaja peab seda numbrit ära arvama
            //kui kasutaja suutis seda numbrit ära arvama, siis ta on mängu võitnud;
            //kastete arv on piiramatu
            //*programm geneererib juhuslikku numbrit ühe korra

            Console.WriteLine("Palun sisestage number 1-10.");

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);
            bool loopActive = true;

            while (loopActive)
            {
                Console.WriteLine("Palun sisestage nr 1-10");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud.");
                    //break
                    loopActive = false;

                }
                else
                {
                    Console.WriteLine("Proovi uuesti!");
                }

                Console.WriteLine("Kena päeva!");
            }
        }
    }
}
