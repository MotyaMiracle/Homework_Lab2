using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    public class Human : IHumanInterface
    {
            public string name;
            public string surname;
            public string lastname;
            public Human(string name, string surname, string lastname)
            {
                this.name = name;
                this.surname = surname;
                this.lastname = lastname;
            }
        public string GetInitials()
            {
                string initials = name + " " + surname + " " + lastname;
                return initials;
            }
    }
}
