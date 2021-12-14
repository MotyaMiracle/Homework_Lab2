using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    public class Employee : Human
    {
        public string iPAW { get; set; }
        public Employee(string surname, string name, string lastname, string PAW) : base (name, surname, lastname)
        {
            iPAW = PAW;
        }
        public string GetPAW()
        {
            return this.iPAW;
        }
    }
}
