using System;

namespace Homework_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем кадровика
            HRE hre = new HRE("Ляхов", "Григорий", "Алексеевич");
            // Объявляем преподавателя и ассистента
            Lecturer lecturer = hre.MakeLecturer("Матвеев", "Олег", "Игоревич", true);
            Lecturer lecturer1 = hre.MakeLecturer("Елисеева", "Мария", "Никитична", false);
            // Объявляем трех студентов
            Student student1 = hre.MakeStudent("Муратов", "Матвей", "Сергеевич");
            Student student2 = hre.MakeStudent("Каролина", "Архипова", "Глебовна");
            Student student3 = hre.MakeStudent("Трефилова", "Диана", "Дмитриевна");
            Console.WriteLine($"ФИО: {hre.GetInitials()} | Должность: {hre.GetPAW()}");
            Console.WriteLine($"ФИО: {lecturer.GetInitials()} | Должность: {lecturer.GetPAW()}");
            Console.WriteLine($"ФИО: {lecturer1.GetInitials()} | Должность: {lecturer1.GetPAW()}");
            Console.WriteLine($"ФИО: {student1.GetInitials()} | Должность: {student1.GetPAW()}");
            Console.WriteLine($"ФИО: {student2.GetInitials()} | Должность: {student2.GetPAW()}");
            Console.WriteLine($"ФИО: {student3.GetInitials()} | Должность: {student3.GetPAW()}");
            Group group = hre.MakeGroup();
            group.NameGroup = "2-1П11";
            group.SetLecturer(lecturer);
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            Console.WriteLine($"Группа студента {student1.GetInitials()} : {student1.GetGroup()}"); ;
            lecturer.Lecture = 32;
            Console.WriteLine("Назначено лекций преподавателю: " + lecturer.Lecture);
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(0,lecturer.Lecture); i++)
            {
                lecturer.Lectured();
            }
            Console.WriteLine("После проведения лекций: " + lecturer.Lecture);
            Console.WriteLine("Студентов в группе: " + group.GetNumberOfStudents());
            student2.DroppedOut();
            Console.WriteLine("Студент отчислился");
            Console.WriteLine("Студентов в группе: " + group.GetNumberOfStudents());
            LecturerPAW BigLecturer = hre.MakePost();
            BigLecturer.NamePost = "Старший преподаватель";
            BigLecturer.AddLecturer(lecturer1);
            Console.WriteLine($"Должность преподавателя {lecturer1.GetInitials()} : {lecturer1.GetNewPost()}");
            lecturer1.Retirement();
        }
    }
}
