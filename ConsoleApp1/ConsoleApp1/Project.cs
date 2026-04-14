using System;
using System.Collections.Generic;

namespace ProjectManagement
{
    public class Project
    {
        public string Name { get; set; }
        private List<TaskItem> tasks = new List<TaskItem>();

        public Project(string name)
        {
            Name = name;
        }

        public void AddTask(TaskItem task)
        {
            tasks.Add(task);
            Console.WriteLine($"Задача \"{task.Title}\" добавлена в проект \"{Name}\"");
        }

        public int GetTotalEstimatedHours()
        {
            int total = 0;
            foreach (var t in tasks)
                total += t.EstimatedHours;
            return total;
        }

        public void ShowAllTasks()
        {
            Console.WriteLine($"\n--- Задачи проекта \"{Name}\" ---");
            foreach (var t in tasks)
            {
                string status = t.IsCompleted ? "Выполнена" : "В работе";
                string assignee = t.AssignedTo != null ? t.AssignedTo.Name : "не назначен";
                Console.WriteLine($"{t.Title} | {t.EstimatedHours} ч. | Исполнитель: {assignee} | {status}");
            }
        }
    }
}