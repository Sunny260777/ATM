using System;

namespace ATM
{
    class Program
    {
        public static int amount = 2034;
        static void Main(string[] args)
        {
            int deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("************ Welcome To Bank ****************");
            Console.WriteLine("Please enter you pin");
            pin = Convert.ToInt32(Console.ReadLine());
            if (pin == 2607)
                WelcomeMenu();
            else
                Console.WriteLine("Wrong Ping Try again later");

            int steps = Convert.ToInt32(Console.ReadLine());
            HandleMenu(steps);
            
        }

        public static void WelcomeMenu() {
            Console.Clear();
            Console.WriteLine("Welcome Sunny Bhardwaj \n");
            Console.WriteLine("1. Current Balance\n");
            Console.WriteLine("2. Withdraw \n");
            Console.WriteLine("3. Deposit \n");
            Console.WriteLine("4. Cancel \n");
        }

        public static void HandleMenu(int steps)
        {
            switch (steps)
            {
                case 1:
                    Console.WriteLine("Your current balance is {0}", amount);
                    break;
                default:
                    break;
            }


        }
    }
}
