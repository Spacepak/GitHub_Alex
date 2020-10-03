using System;

namespace MaDeuxièmeApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(createMessage());
            Console.WriteLine("Bonjour");
        }
        
        public static string createMessage()
        {
            return "Hello world";
            
        }
    }
}
