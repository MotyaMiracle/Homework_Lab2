using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_Lab2
{
    /// <summary>
    /// Класс, реализующий должности преподавателей
    /// </summary>
    public class LecturerPAW
    {
        private string namepost;
        private List<Lecturer> lecturers = new List<Lecturer>();
        // Добавить преподавателя на должность
        public void AddLecturer(Lecturer lecturer)
        {
            this.lecturers.Add(lecturer);
            lecturer.lecturerPAW = this;
        }
        // Ввод названия должности и закрепление должности за преподавателями
        public string NamePost
        {
            get
            {
                return (namepost);
            }
            set
            {
                this.namepost = value;
                foreach (Lecturer lecturer in lecturers) lecturer.lecturerPAW = this;
            }
        }
        // Обновить количество преподавателей в случае увольнения
        public void UpTeacherData()
        {
            try
            {
                foreach (Lecturer lecturer in lecturers)
                {
                    if (lecturer.thispost == false) lecturers.Remove(lecturer);
                }
            }
            catch { }
        }
    }
}
