using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    // Интерфейс, объявляющий Имя, Фамилию, Отчество, Инициалы и Должность
    interface IEmployeeInterface
    {
        string isurname { get; set; }
        string iname { get; set; }
        string ilastname { get; set; }
        string iPAW { get; set; }
        string GetInitials();
        string GetPAW();
    }
    public abstract class Employee : IEmployeeInterface
    {
        public string iname { get; set; }
        public string isurname { get; set; }
        public string ilastname { get; set; }
        public string iPAW { get; set; }
        public Employee(string surname, string name, string lastname, string PAW)
        {
            isurname = surname;
            iname = name;
            ilastname = lastname;
            iPAW = PAW;
        }
        public string GetInitials()
        {
            string initials = isurname + " " + iname + " " + ilastname;
            return initials;
        }
        // Метод, возвращающий должность
        public string GetPAW()
        {
            return this.iPAW;
        }
    }
}
