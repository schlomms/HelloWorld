using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            string Salut = "helloWorld";
            DateTime dateActuelle = DateTime.Now;
            Console.WriteLine(dateActuelle.ToString("r", CultureInfo.CreateSpecificCulture("fr-FR")));
            Console.WriteLine(Salut);
            Console.WriteLine(dateActuelle);
            Console.WriteLine($"{Salut}");
            Console.WriteLine(Salut.Length);
            Console.Read();
        }   
    }
}