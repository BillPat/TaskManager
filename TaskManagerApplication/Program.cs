using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManagerApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            TaskManager taskManager = new TaskManager();

            // Προσθήκη έγκυρης εργασίας
            Console.WriteLine("Adding a valid task...");
            Task validTask = new Task("Complete Project", "C# project", 3, DateTime.Now.AddDays(3));
            taskManager.AddTask(validTask);

            // Προσθήκη μη έγκυρης εργασίας (με κενό τίτλο)
            Console.WriteLine("Adding an invalid task with empty title...");
            Task invalidTask1 = new Task("", "empty title", 2, DateTime.Now.AddDays(2));
            taskManager.AddTask(invalidTask1);

            // Προσθήκη μη έγκυρης εργασίας (με ημερομηνία στο παρελθόν)
            Console.WriteLine("Adding an invalid task with past due date...");
            Task invalidTask2 = new Task("Past Task", "This task has a due date in the past", 4, DateTime.Now.AddDays(-5));
            taskManager.AddTask(invalidTask2);

            // Εμφάνιση των εργασιών που έχουν προστεθεί
            Console.WriteLine("\nCurrent tasks:");
            taskManager.ViewTasks();

            // Αποθήκευση των εργασιών σε αρχείο
            Console.WriteLine("\nSaving tasks to file...");
            taskManager.SaveTasksToFile();

            // Φόρτωση των εργασιών από το αρχείο
            Console.WriteLine("\nLoading tasks from file...");
            taskManager.LoadTasksFromFile();

            // Εμφάνιση των εργασιών που φορτώθηκαν από το αρχείο
            Console.WriteLine("\nTasks loaded from file:");
            taskManager.ViewTasks();

            Application.Run(new MainForm());

        }
    }
}
