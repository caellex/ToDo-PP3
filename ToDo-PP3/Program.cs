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
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("Menu for To Do-app:");
            Console.ResetColor();
            Console.WriteLine("1. Create new task");
            Console.WriteLine("2. Show tasks");
            Console.WriteLine("3. Exit program");

            var userInput = Console.ReadLine();

            switch (userInput)
            {
                case "1":
                    program.CreateTask();
                    break;
                case "2":
                    program.ShowTasks();
                    break;
                case "3":
                    Environment.Exit(0);
                    break;
                default:
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("Invalid input. Please enter in 1, 2 or 3");
                    Console.ResetColor();
                    Thread.Sleep(1000);
                    break;
            }
        }
    }
}
