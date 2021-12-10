using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    public class Lecturer : Employee
    {
        public Lecturer(string name, string surname, string lastname) : base(name, surname, lastname, "Преподаватель")
        {

        }
        // Должность
        public LecturerPAW lecturerPAW;
        // Проверка на обучение
        public bool thispost = true;
        // Количество лекций
        private int lecture;
        // По умолчанию групп нет
        private Group group = null;
        // Возвращает количество лекций
        public int Lecture
        {
            set
            {
                if (group != null)
                {
                    this.lecture = value;
                }
            }
            get
            {
                return (this.lecture);
            }
        }
        // Назначение группы
        public void SetGroup(Group group)
        {
            this.group = group;
        }
        // Лекция проведена
        public void Lectured()
        {
            this.lecture--;
        }
        // Вывод группы
        public string GetNewPost()
        {
            return (this.lecturerPAW.NamePost);
        }
        public void Retirement()
        {
            this.thispost = false;
            lecturerPAW.UpTeacherData();
        }
    }
    /// <summary>
    /// Студент, унаследованный от работника
    /// </summary>
    public class Student : Employee
    {
        public Student(string surname, string name, string lastname) : base(surname, name, lastname, "Студент")
        {

        }
        // Объявляем группу
        public Group group;
        // Проверка на обучение
        public bool studies = true;

        // Вывести группу студента
        public string GetGroup()
        {
            return (this.group.NameGroup);
        }
        // Студент отчислился
        public void DroppedOut()
        {
            this.studies = false;
            group.UpData();
        }
    }
}
