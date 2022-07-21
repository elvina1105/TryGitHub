using System;

namespace TryGitHub1
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputAngka = "0"; int angka;
            inputAngka = Console.ReadLine();
            angka = Int32.Parse(inputAngka);
            if(angka < 11)
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
            }
            else if(angka > 10 && angka<20){
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
            }
            else
            {
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
                Console.WriteLine("Hello World!");
            }
            
        }
    }
}
