using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ModelLayer;

namespace Logic
{
    public class Controler
    {
        Person person;

        public Controler(string firstName, string lastName, DateTime dateOfBirth)
        {
            person = new Person();
            person.FirstName = firstName;
            person.LastName = lastName;
            person.DateOfBirth = dateOfBirth;
        }

        public Controler()
        {
            person = new Person();
        }

        public bool setFirstName(string firstName)
        {
            if (firstName.Length != 0)
            {
                person.FirstName = firstName;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setLastName(string lastName)
        {
            if (lastName.Length != 0)
            {
                person.LastName = lastName;
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setDateOfBirth(DateTime dateOfBirth)
        {
            if (dateOfBirth <= DateTime.Now)
            {
                person.DateOfBirth = dateOfBirth;
                return true;
            }
            else
            {
                return false;
            }
        }

        public String GetFirstName()
        {
            return person.FirstName;
        }

        public String GetLastName()
        {
            return person.LastName;
        }

        public DateTime GetDateOfBirth()
        {
            return person.DateOfBirth;
        }

        public int GetAge()
        {
            AgeLogic ageLogic = new AgeLogic(person);
            return ageLogic.GetAge();
        }

        public int GetDaysToBD()
        {
            AgeLogic ageLogic = new AgeLogic(person);
            return ageLogic.GetDaysToBD();
        }
    }
}
