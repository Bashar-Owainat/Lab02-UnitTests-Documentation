using System;

namespace UnitTestsApp
{
    public class Program
    {
        static public decimal Balance;
        static void Main(string[] args)
        {
            Deposit(5000);
            UserInterface();
        }

        public static decimal ViewBalance()
        {
            Console.WriteLine("Your current Balance is: "+Balance);
            return Balance;
        }


        public static decimal WithDraw(decimal input)
        {
            if(input  > Balance)
            {
                throw new ArgumentException("Error! You can not withdraw more than what you have in your balance");
                
            }
            else
            {
                return Balance -= input;
            }
        }


        public static decimal Deposit(decimal input)
        {
            if(input < 0)
            {
                throw new ArgumentException("Error! You can not deposit a negitive value!");

                
            }
            else
            {
                return Balance += input;
            }
            
        }

        public static void UserInterface()
        {
            Console.WriteLine("Choose one of these operations, to pick an operation enter it's number");
            Console.WriteLine("1- Deposit");
            Console.WriteLine("2- Withdraw");
            Console.WriteLine("3- View Balance");
            Console.WriteLine("4- Exit");

            int userInput = Convert.ToInt32(Console.ReadLine());
            String[] receipt = new string[100];
            int counter = 0;
            while (userInput != 4)
            {
                if (userInput == 1)
                {
                    Console.WriteLine("Please enter how much you want to deposit");
                    decimal depositInput = Convert.ToDecimal(Console.ReadLine());
                    Deposit(depositInput);
                    receipt[counter] = "You deposited " + depositInput + " JDs";
                }

                else if(userInput == 2)
                {
                    Console.WriteLine("Please enter how much you want to Withdraw");
                    decimal WithDrawInput = Convert.ToDecimal(Console.ReadLine());
                    WithDraw(WithDrawInput);
                    receipt[counter] = "You withdrew " + WithDrawInput + " JDs";
                }

                else if(userInput == 3)
                {
                   decimal balance = ViewBalance();
                    receipt[counter] = "You viewed your Balance and  it was " + balance + " JDs";
                }
                counter++;
                Console.WriteLine("Choose one of these operations, to pick an operation enter it's number");
                Console.WriteLine("1- Deposit");
                Console.WriteLine("2- Withdraw");
                Console.WriteLine("3- View Balance");
                Console.WriteLine("4- Exit");
                userInput = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("Thanks for using our bank here is a receipt with all transactions you did");
            Console.WriteLine("----------------------------------------------------------------------------");
            for(int i = 0; i < receipt.Length; i++)
            {
                if(receipt[i] != null)
                {
                Console.WriteLine(receipt[i]);
                }
                else
                {
                    break;
                }
            }
           
            Console.WriteLine("----------------------------------------------------------------------------");


        }
    }
}
