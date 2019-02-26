using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Program();

            p.BasicEventLoop();
        }

        public void BasicEventLoop()
        {
            string PromptForInput()
            {
                string prompt = @"Options:\n\t1 - Attack \n\t2 -  Defend\n\tq - Quit\nChoice: ";

                Console.Write(prompt);
                return Console.ReadLine();

            }
            string input = PromptForInput();

            while (input != "q")
            {
                try
                {
                    int i = int.Parse(input);

                    Console.WriteLine($"Your input was {i}");
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Try again!");
                }

                input = Console.ReadLine();
            }
         

        }
    }
}
