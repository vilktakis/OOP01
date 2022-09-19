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
        AgeLogic ageLogic;

        public Controler(string firstNname, string lastName, DateTime dateOfBirth)
        {
            person = new Person();
            person.FirstName = firstNname;
            person.LastName = lastName;
            person.DateOfBirth = dateOfBirth;

            ageLogic = new AgeLogic(person);
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
            return ageLogic.GetAge();
        }

        public int GetDaysToBD()
        {
            return ageLogic.GetDaysToBD();
        }
    }
}
