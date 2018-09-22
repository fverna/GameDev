using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple test app for learning C#.\n");
            while(!GetName());
            while(!GetAge());
            Console.ReadKey();
        }

        private static bool GetName()
        {
            Console.WriteLine("Please enter your name: ");
            String name = Console.ReadLine();
            Console.WriteLine("You input '{0}' as your name, is this correct? [Y/n]", name);
            char check = Convert.ToChar(Console.ReadLine());
            if ((check == 'Y') || (check == 'y'))
            {
                Console.WriteLine("Perfect. It's great to meet you {0}!\n", name);
                return true;
            }
            else if ((check == 'N') || (check == 'n'))
                Console.WriteLine("Oops, something went wrong then. Let's try again.\n");
            else
                Console.WriteLine("Sorry, I don't recognize that response. Let's try again.\n");
            return false;
        }

        private static bool GetAge()
        {
            Console.WriteLine("Please enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("You input '{0}' as your age, is this correct? [Y/n]", age);
            char check = Convert.ToChar(Console.ReadLine());
            if ((check == 'Y') || (check == 'y'))
            {
                Console.WriteLine("Ripe old age of {0}, huh? Huehuehue.\n", age);
                return true;
            }
            else if ((check == 'N') || (check == 'n'))
                Console.WriteLine("Oops, something went wrong then. Let's try again.\n");
            else
                Console.WriteLine("Sorry, I don't recognize that response. Let's try again.\n");
            return false;
        }
    }
}
