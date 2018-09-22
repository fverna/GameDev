using System;

namespace App1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a simple test app for learning C#.\n");
            String name = GetName();
            int age = GetAge();
            string home = GetHome();
            Console.WriteLine("Well then {0} of {1}, age {2}, let's get to developing!\n", name, home, age);
            Console.ReadKey();
        }

        private static String GetName()
        {
            while (true)
            {
                Console.WriteLine("Please enter your name: ");
                String name = Console.ReadLine();
                Console.WriteLine("You input '{0}' as your name, is this correct? [Y/n]", name);
                char check = Convert.ToChar(Console.ReadLine());
                if ((check == 'Y') || (check == 'y'))
                {
                    Console.WriteLine("Perfect. It's great to meet you {0}!\n", name);
                    return name;
                }
                else if ((check == 'N') || (check == 'n'))
                    Console.WriteLine("Oops, something went wrong then. Let's try again.\n");
                else
                    Console.WriteLine("Sorry, I don't recognize that response. Let's try again.\n");
            }
        }

        private static int GetAge()
        {
            int age = -1;
            while (true)
            {
                Console.WriteLine("Please enter your age: ");
                try
                {
                    age = Convert.ToInt32(Console.ReadLine());
                } catch (FormatException e)
                {
                    Console.WriteLine("Please enter decimal numbers only, we aren't dirty hex users 'round these parts.");
                    continue;
                }
                Console.WriteLine("You input '{0}' as your age, is this correct? [Y/n]", age);
                char check = Convert.ToChar(Console.ReadLine());
                if ((check == 'Y') || (check == 'y'))
                {
                    Console.WriteLine("Ripe old age of {0}, huh? Huehuehue.\n", age);
                    return age;
                }
                else if ((check == 'N') || (check == 'n'))
                    Console.WriteLine("Oops, something went wrong then. Let's try again.\n");
                else
                    Console.WriteLine("Sorry, I don't recognize that response. Let's try again.\n");
            } 
        }

        private static String GetHome()
        {
            while (true)
            {
                Console.WriteLine("Well now that I have your name and age, mind sharing where you are from?");
                String place = Console.ReadLine();
                Console.WriteLine("You input '{0}' as your home, is this correct? [Y/n]", place);
                char check = Convert.ToChar(Console.ReadLine());
                if ((check == 'Y') || (check == 'y'))
                {
                    Console.WriteLine("Ahh, a man of culture I see.\n");
                    return place;
                }
                else if ((check == 'N') || (check == 'n'))
                    Console.WriteLine("Oops, something went wrong then. Let's try again.\n");
                else
                    Console.WriteLine("Sorry, I don't recognize that response. Let's try again.\n");
            }
        }
    }
}
