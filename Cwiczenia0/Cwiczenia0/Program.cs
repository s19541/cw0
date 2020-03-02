using System;
using System.Net.Http;

namespace Cwiczenia0
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var client = new HttpClient();
            int g = 0;
            for(int i = 0; i < 10; 1++)
            {
                g += 1;
            }
            //komentarz
        }
    }
}
