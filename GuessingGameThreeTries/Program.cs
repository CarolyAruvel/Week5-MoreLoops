using System;

namespace GuessingGameThreeTries
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            //programm genereerib juhuslikku numbrit 1 kuni 10;
            //kasutaja peab seda numbrit ära arvama;
            //kui kasutaja suutis selle numbri ära arvata, siis ta on mängu võitnud
            //kasutajal on kolm kastet, kui kasutaja ei ole suutnud 3 katsega numbrit ära arvata
            //siis mängu võidab arvuti
            //*programm genereerib juhuslikku numbrit ühe korra

            Random rnd = new Random();
            int cpuRandom = rnd.Next(1, 11);

            int i = 0;
            while (i < 3) ;
            {
                Console.WriteLine("Vali number 1-10:");
                int userNumber = Convert.ToInt32(Console.ReadLine());

                if (cpuRandom == userNumber)
                {
                    Console.WriteLine("Palju õnne! Oled võitnud.");
                    //break
                    i = 3;

                }
                else
                {
                    i = i + 1;
                    Console.WriteLine($"Proovi uuesti. {3 - i} katset jäänud.");
                }

                Console.WriteLine("Head päeva!");
            }
        }
            
    }
}
