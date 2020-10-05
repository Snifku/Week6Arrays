using System;

namespace UserAgainstZombies
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] backpack = new string[4] ;
            Random rnd = new Random();
            Console.WriteLine("whats in your backpack");
            string userinput = Console.ReadLine().ToLower();
            backpack[0] = userinput;
            userinput = Console.ReadLine().ToLower();
            backpack[1] = userinput;
            userinput = Console.ReadLine().ToLower();
            backpack[2] = userinput;
            userinput = Console.ReadLine().ToLower();
            backpack[3] = userinput;
            userinput = Console.ReadLine().ToLower();
            backpack[4] = userinput;
            int random = rnd.Next(0, backpack.Length);
            Console.WriteLine($"find {backpack[random]} in your backpack");
            

        }
    }
}
