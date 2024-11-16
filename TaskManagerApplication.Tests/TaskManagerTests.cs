using System;
using System.IO;
using TaskManagerApplication;
using Xunit;

namespace TaskManagerApplicationTests
{
    public class TaskManagerTests
    {
        [Fact]
        public void AddTask_ShouldAddValidTask()
        {
            // Arrange
            var taskManager = new TaskManager();
            var task = new TaskManagerApplication.Task("Test Task", "Description", 3, DateTime.Now.AddDays(1));

            // Act
            taskManager.AddTask(task);

            // Assert
            Assert.Contains(task, taskManager.GetTasks());
        }

        [Fact]
        public void AddTask_ShouldNotAddInvalidTask()
        {
            // Arrange
            var taskManager = new TaskManager();
            var task = new TaskManagerApplication.Task("", "Description", 6, DateTime.Now.AddDays(-1)); // Invalid task

            // Act
            taskManager.AddTask(task);

            // Assert
            Assert.DoesNotContain(task, taskManager.GetTasks());
        }

        [Fact]
        public void SaveTasksToFile_ShouldCreateFile()
        {
            // Arrange
            var taskManager = new TaskManager();
            var task = new TaskManagerApplication.Task("Sample Task", "Sample Description", 2, DateTime.Now.AddDays(1));
            taskManager.AddTask(task);
            string filePath = "tasks.json";

            // Act
            taskManager.SaveTasksToFile();

            // Assert
            Assert.True(File.Exists(filePath));

            // Cleanup
            File.Delete(filePath);
        }

        [Fact]
        public void LoadTasksFromFile_ShouldLoadTasks()
        {
            // Arrange
            var taskManager = new TaskManager();
            var task = new TaskManagerApplication.Task("Sample Task", "Sample Description", 2, DateTime.Now.AddDays(1));
            taskManager.AddTask(task);
            taskManager.SaveTasksToFile();

            var newTaskManager = new TaskManager();

            // Act
            newTaskManager.LoadTasksFromFile();

            // Assert
            Assert.NotEmpty(newTaskManager.GetTasks());

            // Cleanup
            File.Delete("tasks.json");
        }
    }
}
