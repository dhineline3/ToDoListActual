using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDoListActual
{
    class Program
    {
        static void Main(string[] args)
        {


            var quit = false;
            var tasks = new List<string>();

            //Load the l

            do
            {
                //Main user interface
                Console.Clear();
                Console.WriteLine("Task List");
                Console.WriteLine("--------");
                Console.WriteLine("   1. Add a task. ");
                Console.WriteLine("   2. Display task list. ");
                Console.WriteLine("   0. Quit. ");

                Console.WriteLine("  Select your item: ");
                var input = Console.ReadLine();

                if (input == "0")
                {
                    //Quit the program
                    quit = true;
                }
                else if (input == "1")
                {
                    //Enter new task here
                    Console.WriteLine("Enter your task: ");
                    var newTask = Console.ReadLine();

                    tasks.Add(newTask);
                }
                else if (input == "2")
                {
                    Console.Clear();
                    //Print the list here
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        //The square brackets access one index in the list
                        //It's important we start at 0 becuase lists and arrays are 0-indexed
                        Console.WriteLine($"{i + 1}. {tasks[i]}");
                    }
                    Console.WriteLine("Press any key to return to the main menu: ");
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Input...\n");
                    Console.ReadKey();
                }

            } while (!quit);


        }            //Save the list from a file HERE
    }
    }
}
