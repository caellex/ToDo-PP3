using ToDo_PP3;

namespace ToDoListPP;

class Program
{
    static void Main(string[] args)
    {

        ToDoProgram program = new ToDoProgram();
        ToDoProgram.LoadTasks();

        while (true)
        {
            Console.Clear();
            Console.WriteLine("Meny for To Do-app:");
            Console.WriteLine("1. Create new task");
            Console.WriteLine("2. Show tasks");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    program.CreateTask();
                    break;
                case "2":
                    program.ShowTasks();
                    break;
            }

        }
    }


}