using System;

namespace ProjectManagement
{
    public class TaskItem
    {
        public string Title { get; set; }
        public int EstimatedHours { get; set; }
        public Employee AssignedTo { get; set; }
        public bool IsCompleted { get; set; }

        public TaskItem(string title, int hours)
        {
            Title = title;
            EstimatedHours = hours;
            IsCompleted = false;
        }

        public void AssignTo(Employee employee)
        {
            AssignedTo = employee;
            Console.WriteLine($"Задача \"{Title}\" назначена на {employee.Name}");
        }

        public void Complete()
        {
            IsCompleted = true;
            Console.WriteLine($"Задача \"{Title}\" выполнена!");
        }
    }
}