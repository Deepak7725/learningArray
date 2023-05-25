using System;

namespace learningArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] friends = { "kathir", "vicky", "hari", "nicky", "john" };
            foreach (string friend in friends)
            {
                Console.WriteLine("Welcome {0}",friend);
            }
        }
    }
}
