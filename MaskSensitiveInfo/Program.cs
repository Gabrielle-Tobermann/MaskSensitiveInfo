using System;

namespace MaskSensitiveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your SSN");
            var userString = Console.ReadLine();
            // .substring returns a chunk of a string. PadLeft will cover the substring with a unicode 
            string result = userString.Substring(userString.Length - 4).PadLeft(userString.Length, '*');
            Console.WriteLine(result);
        }
    }
}
