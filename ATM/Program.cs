using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            int amount = 2034, deposit, withdraw;
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
            }
            else{
                Console.WriteLine("Wrong Ping Try again later");
            }

            Console.ReadLine();
        }
    }
}
