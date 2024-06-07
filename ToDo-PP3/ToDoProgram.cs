using System;
using System.Collections.Generic;
using System.Linq;
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
            Console.WriteLine($"Task: {taskNameInput} added!");
            Thread.Sleep(2000);
        }

        public void ShowTasks()
        {
            Console.Clear();
            int i = 0;
            foreach (ToDo task in Tasks)
            {
                Console.WriteLine($"Task Name: {task.Task}");
                Console.WriteLine($"Task Description: {task.Description}");
                Console.WriteLine($"ID: {i}\n");
                i++;
            }
            
            

            Console.WriteLine("Type out any ID to remove the specific task, or press any key to go back..");
            char userChoice = Console.ReadKey().KeyChar;


            if (Int32.TryParse(userChoice.ToString(), out int indexToRemove))
            {
                if(indexToRemove <= Tasks.Count - 1){
                Console.WriteLine($"Task '{Tasks[indexToRemove].Task}' removed successfully!");
                Tasks.RemoveAt(indexToRemove);
                Thread.Sleep(3000);
                }
                else
                {
                    Console.WriteLine($"Please choose an existing task!");
                    Thread.Sleep(1500);
                }
            }
        }

        public static void LoadTasks()
        {
            ToDo task1 = new ToDo("wash windows", "washing kitchen windows");
            Tasks.Add(task1);
        }
    }


}

// Fjerne beskrivelse fra Show Tasks -  Legge til beskrivelse når du går inn i en task istedenfor
// Trekke ut ting i flere metoder
// Se på en annen måte å slette tasks på (Kanskje du kan velge å slette når du går inn? (Følger indexToRemove)