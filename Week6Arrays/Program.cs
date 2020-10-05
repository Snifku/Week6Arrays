using System;

namespace Week6Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] predictions = { "win a million", "lose your smartphone", "fall in love", "buy youtube premium", "get a cookie" };
            Random rnd = new Random();
            int randomindex = rnd.Next(0, predictions.Length);
            Console.WriteLine($"today you will {predictions[randomindex]}.");
        }
    }
}
