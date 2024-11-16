using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace TaskManagerApplication
{
    public class TaskManager
    {
        private List<Task> tasks = new List<Task>();
        private const string FilePath = "tasks.json";

        public void AddTask(Task task)
        {
            if (ValidateTask(task))
            {
                tasks.Add(task);
                Console.WriteLine("Task added successfully!");
            }
        }

        private bool ValidateTask(Task task)
        {
            if (string.IsNullOrWhiteSpace(task.Title))
            {
                Console.WriteLine("Error: Title is required.");
                return false;
            }

            if (task.Priority < 1 || task.Priority > 5)
            {
                Console.WriteLine("Error: Priority must be between 1 and 5.");
                return false;
            }

            if (task.DueDate < DateTime.Now.Date)
            {
                Console.WriteLine("Error: Due date cannot be in the past.");
                return false;
            }

            return true;
        }

        public void ViewTasks()
        {
            foreach (var task in tasks)
            {
                task.DisplayTask();
                Console.WriteLine("------------");
            }
        }

        public void SaveTasksToFile()
        {
            try
            {
                string json = JsonSerializer.Serialize(tasks);
                File.WriteAllText(FilePath, json);
                Console.WriteLine("Tasks saved to file successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error saving tasks to file: {ex.Message}");
            }
        }

        public void LoadTasksFromFile()
        {
            try
            {
                if (File.Exists(FilePath))
                {
                    string json = File.ReadAllText(FilePath);
                    tasks = JsonSerializer.Deserialize<List<Task>>(json) ?? new List<Task>();
                    Console.WriteLine("Tasks loaded from file successfully.");
                }
                else
                {
                    Console.WriteLine("No saved tasks found.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error loading tasks from file: {ex.Message}");
            }
        }
        public List<Task> GetTasks()
        {
            return tasks;
        }

    }

}

