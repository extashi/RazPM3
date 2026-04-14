using System;

namespace ProjectManagement
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }

        public Employee(int id, string name, string position)
        {
            Id = id;
            Name = name;
            Position = position;
        }

        public void WorkOnTask(string taskTitle)
        {
            Console.WriteLine($"{Name} ({Position}) работает над задачей: {taskTitle}");
        }
    }
}