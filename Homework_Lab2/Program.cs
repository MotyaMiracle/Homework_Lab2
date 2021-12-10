using System;

namespace Homework_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Объявляем кадровика
            HRE hre = new HRE("Ляхов", "Григорий", "Алексеевич");
            // Объявляем преподавателя
            Lecturer lecturer = hre.MakeLecturer("Матвеев", "Олег", "Игоревич");
            // Объявляем двух студентов
            Student student1 = hre.MakeStudent("Муратов", "Матвей", "Сергеевич");
            Student student2 = hre.MakeStudent("Каролина", "Архипова", "Глебовна");
            Student student3 = hre.MakeStudent("Трефилова", "Диана", "Дмитриевна");
            // Выводим ФИО и должности всех людей
            Console.WriteLine($"ФИО: {hre.GetInitials()} | Должность: {hre.GetPAW()}");
            Console.WriteLine($"ФИО: {lecturer.GetInitials()} | Должность: {lecturer.GetPAW()}");
            Console.WriteLine($"ФИО: {student1.GetInitials()} | Должность: {student1.GetPAW()}");
            Console.WriteLine($"ФИО: {student2.GetInitials()} | Должность: {student2.GetPAW()}");
            Console.WriteLine($"ФИО: {student3.GetInitials()} | Должность: {student3.GetPAW()}");
            // Создаем новую группу студентов
            Group group = hre.MakeGroup();
            // Задаем имя группы
            group.NameGroup = "2-1П11";
            // Назначаем преподавателя в группу
            group.SetLecturer(lecturer);
            // Добавляем в группу двух студентов
            group.AddStudent(student1);
            group.AddStudent(student2);
            group.AddStudent(student3);
            // Вывод названия группы
            Console.WriteLine($"Группа студента {student1.GetInitials()} : {student1.GetGroup()}"); ;
            // Назначаем преподавателю количество лекций
            lecturer.Lecture = 32;
            Console.WriteLine("Назначено лекций преподавателю: " + lecturer.Lecture);
            // Преподаватель провел несколько лекций
            Random rnd = new Random();
            for (int i = 0; i < rnd.Next(0,lecturer.Lecture); i++)
            {
                lecturer.Lectured();
            }
            Console.WriteLine("После проведения лекций: " + lecturer.Lecture);
            // Вывод количества студентов группы
            Console.WriteLine("Студентов в группе: " + group.GetNumberOfStudents());
            // Студент отчислился
            student2.DroppedOut();
            // Вывод количества студентов группы
            Console.WriteLine("Студент отчислился");
            Console.WriteLine("Студентов в группе: " + group.GetNumberOfStudents());
            // Назначаем преподавателя на должность Ассистента
            // Кадровик создает новую должность
            LecturerPAW assistant = hre.MakePost();
            // Имя новой должности
            assistant.NamePost = "Ассистент";
            // Добавляем на новую должность
            assistant.AddLecturer(lecturer);
            // Выводим ФИО и его новую должность
            Console.WriteLine($"Должность преподавателя {lecturer.GetInitials()} : {lecturer.GetNewPost()}");
            // Снимаем преподавателя с должности
            lecturer.Retirement();
            // Назначаем на должность Главного Учителя
            // Создание новой должности
            LecturerPAW BigLecturer = hre.MakePost();
            // Название новой должности
            BigLecturer.NamePost = "Старший преподаватель";
            // Добавляем на новую должность
            BigLecturer.AddLecturer(lecturer);
            // Выводим ФИО и его новую должность
            Console.WriteLine($"Должность преподавателя {lecturer.GetInitials()} : {lecturer.GetNewPost()}");
            // Снимаем с должности
            lecturer.Retirement();
        }
    }
}
