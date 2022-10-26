using System;

namespace TSKmgPROP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            menu menu = new menu();
            int action = 0;

            while (action != 4)
            {

                menu.drawMenu();

                action = Convert.ToInt32(Console.ReadLine());

                if (action == 1)
                {
                    Console.Clear();
                    menu.drawTask();
                    Console.WriteLine();
                }

                if (action == 2)
                {
                    Console.Clear();
                    Console.WriteLine("Write a task to append: ");
                    string task = Console.ReadLine();
                    Console.Clear();
                    menu.setTask(task);
                }

                if (action == 3)
                {
                    Console.Clear();
                    int indexToDelete = Convert.ToInt32(Console.ReadLine());
                    menu.setIndex(indexToDelete - 1);
                    menu.delTask();
                }

                if (action == 4)
                {
                    Console.Clear();
                    Console.WriteLine("Closing...");
                    Console.WriteLine();
                }

                if (action != 1 && action != 2 && action != 3 && action != 4)
                {
                    Console.Clear();
                }
            }
        }
    }

}
