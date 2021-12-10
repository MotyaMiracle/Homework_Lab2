using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    /// <summary>
    /// Класс, реализующий группу студентов
    /// </summary>
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
        // Добавить студента в группу
        public void AddStudent(Student student)
        {
            this.students.Add(student);
            student.group = this;
        }
        // Ввод названия группы и закрепление группы за студентами
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
        // Получить количество студентов
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
    /// <summary>
    /// Класс Кадровик, унаследованный от работника
    /// </summary>
    public class HRE : Employee
    {
        public HRE(string surname, string name, string lastname) : base(surname, name, lastname, "Кадровик")
        {

        }
        // Добавить студента в группу
        public void AddStudent(Group group, Student student)
        {
            group.AddStudent(student);
        }
        // Создать студента и добавить ФИО
        public Student MakeStudent(string surname, string name, string lastname)
        {
            return (new Student(surname, name, lastname));
        }
        // Создать группу
        public Group MakeGroup()
        {
            return (new Group());
        }
        // Создать преподавателя
        public Lecturer MakeLecturer(string surname, string name, string lastname)
        {
            return (new Lecturer(surname, name, lastname));
        }
        // Создать должность
        public LecturerPAW MakePost()
        {
            return (new LecturerPAW());
        }
    }
}
