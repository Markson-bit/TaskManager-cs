using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TSKmgPROP
{
    class menu
    {
        string filePath = @"YOUR'S PATH there";
        int indexToDelete;

        public void drawMenu()
        {
            Console.WriteLine("What do you want to do?");
            Console.WriteLine("1 - Show existing tasks");
            Console.WriteLine("2 - Add new task");
            Console.WriteLine("3 - Delete existing task");
            Console.WriteLine("4 - Save'n exit");
        }
        public void setTask(string task)
        {
            File.AppendAllText(filePath, task + Environment.NewLine);
        }

        public void drawTask()
        {
            string[] insideFile = File.ReadAllLines(filePath);
            int indexCounter = 0;
            foreach (string inside in insideFile)
            {
                indexCounter++;
                Console.WriteLine("[" + indexCounter + "] - " + inside);
            }
        }

        public void setIndex(int indexToDelete)
        {
            this.indexToDelete = indexToDelete;
        }

        public void delTask()
        {
            var lineToDelete = new List<string>(File.ReadAllLines(filePath));
            try
            {
                lineToDelete.RemoveAt(indexToDelete);
            }
            catch
            {
                Console.Clear();
            }
            finally
            {
                File.WriteAllLines(filePath, lineToDelete.ToArray());
            }
        }

    }
    //test
}
