using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CalculeazaOraTinta();
        }
        
        public static void CalculeazaOraTinta()
        {
            Console.Write("Introduce an: ");
            var year = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce luna: ");
            var month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce ziua: ");
            var day = Convert.ToInt32(Console.ReadLine());

            Console.Write("Introduce ora: ");
            var hour = Convert.ToInt32(Console.ReadLine());
            Console.Write("Introduce distanta intre ore: ");
            var hourDistance = Convert.ToInt32(Console.ReadLine());

            var dateTime = new DateTime(year, month, day, hour, 0, 0);

            DateTime targetTime = dateTime.AddHours(hourDistance);

            Console.WriteLine("Ora Initiala " + dateTime);
            Console.WriteLine("Ora Tinta " + targetTime);
            CalculeazaOraTinta();
        }
    }
}
