using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    public class Lecturer : Employee
    {
        public enum PAW
        {
            Assistant,
            HighestLecturer
        }
        static string[] PAWArr = new string[] { "Ассистент", "Старший преподаватель" };
        public Lecturer(string name, string surname, string lastname, PAW pAW) : base(name, surname, lastname, PAWArr[(int)pAW])
        {

        }
        public LecturerPAW lecturerPAW;
        public bool thispost = true;
        private int lecture;
        private Group group = null;
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
        public void SetGroup(Group group)
        {
            this.group = group;
        }
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
    public class Student : Employee
    {
        public Student(string surname, string name, string lastname) : base(surname, name, lastname, "Студент")
        {

        }
        public Group group;
        public bool studies = true;
        public string GetGroup()
        {
            return (this.group.NameGroup);
        }
        public void DroppedOut()
        {
            this.studies = false;
            group.UpData();
        }
    }
}
