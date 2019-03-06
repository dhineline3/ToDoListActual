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
            List<string> tasks = new List<string>();

            var quit = false;
            //var tasks = new List<string>();

            //Load the file HERE.

            do
            {
                //Main user interface.
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
                    //Quit the program.
                    quit = true;
                }
                else if (input == "1")
                {
                    //Enter new task here.
                    Console.WriteLine("Enter your task: ");
                    var newTask = Console.ReadLine();

                    tasks.Add(newTask);

                }
                else if (input == "2")
                    
                {
                    Console.Clear();
                    //Print the list here.
                    for (int i = 0; i < tasks.Count; i++)
                    {
                        //The square brackets access one index in the list.
                        //It's important we start at 0 becuase lists and arrays are 0-indexed.
                        Console.WriteLine($"{i + 1}. {tasks[i]}");

                    }
                    //From the list menu - select the next options.
                    //Want to be able to select individual item according to # as well as return to the main menu.
                    Console.WriteLine("Press the corresponding number to select an item from the list.");
                    Console.WriteLine("Press any key to return to the main menu: ");
                    int a = int.Parse(Console.ReadLine());
                    tasks[(a) - 1] = changeColor();
                    Console.ReadKey();
                }
                else
                {
                    Console.WriteLine("Invalid Input...\n");
                    Console.ReadKey();
                }

            } while (!quit);

                        
        }            //Save the list from a file HERE.
            static string changeColor()
            {
            string b = Console.ForegroundColor = ConsoleColor.DarkGray("");
                return  Console.ForegroundColor = ConsoleColor.DarkGray;
            }
        
    }



    
}
