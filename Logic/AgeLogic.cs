using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace Logic
{
    public class AgeLogic
    {
        Person person;
        public AgeLogic(Person person)
        {
            this.person = person;
        }

        public int GetAge()
        {
            if (DateTime.Now.Month < person.DateOfBirth.Month)
            {
                return DateTime.Now.Year - person.DateOfBirth.Year - 1;
            }
            else if (DateTime.Now.Month == person.DateOfBirth.Month && DateTime.Now.Day < person.DateOfBirth.Day)
            {
                return DateTime.Now.Year - person.DateOfBirth.Year - 1;
            }
            else
            {
                return DateTime.Now.Year - person.DateOfBirth.Year;
            }
        }

        public int GetDaysToBD()
        {
            if (DateTime.Now.Month < person.DateOfBirth.Month)
            {
                DateTime nextBD = new DateTime(DateTime.Now.Year+1, person.DateOfBirth.Month, person.DateOfBirth.Day);
                return (nextBD - DateTime.Now).Days+1;
            }
            else if (DateTime.Now.Month == person.DateOfBirth.Month && DateTime.Now.Day < person.DateOfBirth.Day)
            {
                DateTime nextBD = new DateTime(DateTime.Now.Year, person.DateOfBirth.Month, person.DateOfBirth.Day);
                return (nextBD - DateTime.Now).Days+1;
            }
            else
            {
                DateTime nextBD = new DateTime(DateTime.Now.Year+1, person.DateOfBirth.Month, person.DateOfBirth.Day);
                return (nextBD - DateTime.Now).Days+1;
            }
        }
    }
}
