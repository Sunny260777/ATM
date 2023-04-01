using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int deposit, withdraw;
            int choice, pin = 0;
            Console.WriteLine("************ Welcome To Bank ****************");
            Console.WriteLine("Please enter you pin");
            pin = Convert.ToInt32(Console.ReadLine());

            if (pin==2607){
                Console.Clear();
                Console.WriteLine("Welcome Sunny Bhardwaj \n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                choice = Convert.ToInt32(Console.ReadLine());
                MakeChoice(choice);
            }
            else{
                Console.WriteLine("Wrong Ping Try again later");
            }

            Console.ReadLine();
        }

        public static void MakeChoice(int choice) {
            try
            {
                int amount = 2034;
                Console.Clear();
                switch (choice)
                {
                    case 1: Console.WriteLine("\n Your Balance is {0}",amount);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
