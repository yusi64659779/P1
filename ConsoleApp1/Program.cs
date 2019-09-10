using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many years experance do you have in professional programming");
            string input = Console.ReadLine();
            int year = Convert.ToInt32(input);
            if (year == 0)
                Console.WriteLine("Need lots of practice");
            if (year == 1)
                Console.WriteLine("Looks like you have a liitle experience");
            if (year == 2)
                Console.WriteLine("Wow! You have been doing this fro a little while");
            if (year > 2)
                Console.WriteLine("You are an expert!");
        }



    }
}

