using System;

namespace ProjectManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаём сотрудников
            Employee alice = new Employee(1, "Алиса", "Разработчик");
            Employee bob = new Employee(2, "Боб", "Тестировщик");

            // 2. Создаём задачи
            TaskItem task1 = new TaskItem("Разработать модуль авторизации", 8);
            TaskItem task2 = new TaskItem("Написать юнит-тесты", 4);
            TaskItem task3 = new TaskItem("Составить документацию", 3);

            // 3. Назначаем исполнителей
            task1.AssignTo(alice);
            task2.AssignTo(bob);
            task3.AssignTo(alice);

            // 4. Создаём проект и добавляем задачи
            Project webProject = new Project("Веб-приложение");
            webProject.AddTask(task1);
            webProject.AddTask(task2);
            webProject.AddTask(task3);

            // 5. Выполняем одну задачу (для демонстрации)
            task1.Complete();

            // 6. Генерируем отчёт
            ReportService report = new ReportService();
            report.GenerateProjectReport(webProject);
            report.ShowEmployeeLoad(task1, task2, task3);

            // 7. Ждём нажатия клавиши
            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}