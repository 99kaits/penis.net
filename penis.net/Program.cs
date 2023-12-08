using System;

namespace penis.net
{
    class Program
    {
        static void Main(string[] args)
        {
            string? length;
            if (args.Length == 0)
            {
                Console.Write("integer please: ");
                length = Console.ReadLine();
            }
            else
                length = args[0];
            bool isValid = int.TryParse(length, out int lengthint);
            if (isValid)
            {
                string peener = "B";
                for (int i = 0; i < lengthint; i++)
                {
                    peener += "=";
                }
                peener += "D";
                Console.WriteLine(peener);
            }
            else
            {
                Console.WriteLine("wow not an int");
            }
        }
    }
}
