using System.ComponentModel.DataAnnotations;

namespace penis.net
{
    class Program
    {
        static void Main(string[] args)
        {
            string length;
            if (args.Length == 0)
            {
                Console.Write("integer please: ");
                length = Console.ReadLine();
            }
            else
                length = args[0];
            bool isValid = int.TryParse(length, out global::System.Int32 lengthint);
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
