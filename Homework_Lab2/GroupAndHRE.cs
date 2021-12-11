using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    public class Group
    {
        private string namegroup;
        private Lecturer lecturer;
        private List<Student> students = new List<Student>();
        // Назначить учителя для группы
        public void SetLecturer(Lecturer lecturer)
        {
            lecturer.SetGroup(this);
            this.lecturer = lecturer;
        }
        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.group = this;
        }
        public string NameGroup
        {
            get
            {
                return (namegroup);
            }
            set
            {
                this.namegroup = value;
                foreach (Student student in students) student.group = this;
            }
        }
        public int GetNumberOfStudents()
        {
            return (this.students.Count);
        }
        // Обновить количество студентов в случае отчисления
        public void UpData()
        {
            try
            {
                foreach (Student student in students)
                {
                    if (student.studies == false) students.Remove(student);
                }
            }
            catch { }
        }
    }
    public class HRE : Employee
    {
        public HRE(string surname, string name, string lastname) : base(surname, name, lastname, "Кадровик")
        {

        }
        public void AddStudent(Group group, Student student)
        {
            group.AddStudent(student);
        }
        public Student MakeStudent(string surname, string name, string lastname)
        {
            return (new Student(surname, name, lastname));
        }
        public Group MakeGroup()
        {
            return (new Group());
        }
        public Lecturer MakeLecturer(string surname, string name, string lastname, bool experience)
        {
            if (experience)
            {
                return (new Lecturer(surname, name, lastname, Lecturer.PAW.HighestLecturer));
            }
            else return (new Lecturer(surname, name, lastname, Lecturer.PAW.Assistant));
        }
        public LecturerPAW MakePost()
        {
            return (new LecturerPAW());
        }
    }
}
