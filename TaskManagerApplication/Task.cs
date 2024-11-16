using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApplication
{
    public class Task
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }

        
        public Task(string title, string description, int priority, DateTime dueDate)
        {
            Title = title;
            Description = description;
            Priority = priority;
            DueDate = dueDate;
        }

        
        public void DisplayTask()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Description: {Description}");
            Console.WriteLine($"Priority: {Priority}");
            Console.WriteLine($"Due Date: {DueDate.ToShortDateString()}");
        }
    }


}
