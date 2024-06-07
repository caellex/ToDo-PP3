using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ToDo_PP3
{
    internal class ToDoProgram
    {

        public static List<ToDo> Tasks = new List<ToDo>();

        public void CreateTask()
        {
            Console.Clear();
            Console.Write("What is the task name?: ");
            string taskNameInput = Console.ReadLine();
            Console.Write("\nWhat is the task description?: ");
            string taskDescInput = Console.ReadLine();

            ToDoProgram.Tasks.Add(new ToDo(taskNameInput, taskDescInput));
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Task: {taskNameInput} added!");
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        public void ShowTasks()
        {
            Console.Clear();
            int i = 0;
            if (Tasks.Count > 0)
            {
                PrintAllTasks(i);

                SpecificTaskMenu();
            }
            else
            {
                FinishedTasks();
            }
        }

        private void PrintAllTasks(int i)
        {
            foreach (ToDo task in Tasks)
            {
                Console.WriteLine($"Task Name: {task.Task}");
                Console.WriteLine($"ID: {i + 1}\n");
                i++;
            }
        }

        private void SpecificTaskMenu()
        {
            Console.WriteLine("Choose the ID of the task you want to show");
            char userChoice = Console.ReadKey().KeyChar;


            if (Int32.TryParse(userChoice.ToString(), out int indexToRemove))
            {
                if (indexToRemove - 1 <= Tasks.Count - 1)
                {
                    Console.WriteLine("Choose the ID of the task you want to show");
                    ShowSpecificTask(indexToRemove - 1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Please choose an existing task!");
                    Console.ResetColor();
                    Thread.Sleep(1500);
                }
            }
        }

        private void FinishedTasks()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You have finished all your tasks! Go get a beer.");
            Console.ResetColor();
            Thread.Sleep(2000);
        }

        private void ShowSpecificTask(int index)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"\nName of task: ");
            Console.ResetColor();
            Console.Write($"{Tasks[index].Task}\n");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write($"Description of task: ");
            Console.ResetColor();
            Console.Write($"{Tasks[index].Description}\n\n");
            
            TaskMenu(index);
        }

        private void TaskMenu(int index)
        {
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("What do you want to do with this task?");
            Console.ResetColor();
            Console.WriteLine("1. Remove it from the list");
            Console.WriteLine("2. Go back to main menu");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"{Tasks[index].Task} is now successfully deleted!");
                    Console.ResetColor();
                    Tasks.RemoveAt(index);
                    Thread.Sleep(2000);
                    break;
                case "2":
                    break;
            }
        }

        public static void LoadTasks()
        {
            ToDo task1 = new ToDo("wash windows", "washing kitchen windows");
            ToDo task2 = new ToDo("wash living room", "wash floors, tv and sofa");
            ToDo task3 = new ToDo("clean kitchen", "Do dishes, clean fridge, wash windows");
            Tasks.Add(task1);
            Tasks.Add(task2);
            Tasks.Add(task3);
        }
    }
}

