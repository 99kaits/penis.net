using System;
namespace penis.net
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("integer please: ");
            string length = Console.ReadLine();
            int lengthint;
            bool isValid = int.TryParse(length, out lengthint);
            if (isValid)
            {
                Console.Write('B');
                for (int i = 0; i < lengthint; i++)
                {
                    Console.Write('=');
                }
                Console.WriteLine('D');
            }
            else
            {
                Console.WriteLine("wow not an int");
            }
        }
    }
}