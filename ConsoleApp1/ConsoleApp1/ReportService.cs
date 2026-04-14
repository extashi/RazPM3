using System;

namespace ProjectManagement
{
    public class ReportService
    {
        public void GenerateProjectReport(Project project)
        {
            Console.WriteLine($"\n===== ОТЧЁТ ПО ПРОЕКТУ: {project.Name} =====");
            project.ShowAllTasks();
            Console.WriteLine($"\nОбщая трудоёмкость: {project.GetTotalEstimatedHours()} часов");
            Console.WriteLine("=============================================");
        }

        // Метод, показывающий, сколько задач назначено на каждого сотрудника (дополнительная метрика)
        public void ShowEmployeeLoad(params TaskItem[] tasks)
        {
            Console.WriteLine("\n=== Загрузка сотрудников ===");
            foreach (var task in tasks)
            {
                if (task.AssignedTo != null)
                    Console.WriteLine($"{task.AssignedTo.Name} -> {task.Title} ({task.EstimatedHours} ч.)");
            }
        }
    }
}