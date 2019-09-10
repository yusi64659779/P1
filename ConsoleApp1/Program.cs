using System;

namespace Practice1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("How many years experance do you have in professional programming: ");
            int year = Convert.ToInt32(Console.ReadLine());
            if (year == 0)
                Console.WriteLine("Need lots of practice");
            else if (year == 1)
                Console.WriteLine("Looks like you have a liitle experience");
            else if (year == 2)
                Console.WriteLine("Wow! You have been doing this fro a little while");
            else
                Console.WriteLine("You are an expert!");
        }



    }
}

