using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic;

namespace OOP01
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your First Name:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Type in your Last Name:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Type in you year of birth:");
            int year = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type in you year of month:");
            int month = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Type in you year of day:");
            int day = Int32.Parse(Console.ReadLine());
            DateTime dateOfBirth = new DateTime(year, month, day);
            Controler controler = new Controler(firstName, lastName, dateOfBirth);
            Console.WriteLine("First Name: " + controler.GetFirstName());
            Console.WriteLine("Last Name: " + controler.GetLastName());
            Console.WriteLine("First Name: " + controler.GetDateOfBirth());
            Console.WriteLine("Age: " + controler.GetAge());
            Console.WriteLine("Days to Birth Day: " + controler.GetDaysToBD());
            Console.ReadLine();
        }
    }
}
