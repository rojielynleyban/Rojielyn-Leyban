using System;

public class Program
{
    class mySavings
    {
        private double balance = 100;
        public void checkpin()
        {
            do
            {
                Console.WriteLine("\nEnter your pin: \n\n");
                int pin = int.Parse(Console.ReadLine());

                if (pin != 12345)
                {
                    Console.WriteLine("\nInvalid Pin\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
                else
                {
                    Console.WriteLine("\nAccess Granted\n");
                    Console.Clear();
                    break;
                }
            }
            while (true);
        }

        public double getBal()
        {
            return balance;
        }

        public void goWith(double withdraw)
        {
            if (withdraw % 10 != 0)
            {
                Console.WriteLine("\n PLEASE ENTER THE AMOUNT THAT IS A MULTIPLIER OF 10\n");
            }
            else if (withdraw > (balance - 10))
            {
                Console.WriteLine("\n SORRY! INSUFFICENT BALANCE");
            }
            else if (withdraw > 10000)
            {
                Console.WriteLine("\n WARNING. MAXIMUM WITHDRAWAL AMOUNT IS RS 10000");
                Console.WriteLine("\n PLEASE ENTER THE AMOUNT THAT IS A MULTIPLIER OF 10\n");
            }
            else
            {
                balance = balance - withdraw;
                Console.WriteLine("\n\n PLEASE COLLECT YOUR CASH");
                Console.WriteLine("\n CURRENT BALANCE IS Rs : {0}\n\n", balance);
            }
        }

        public void goDep(double deposit)
        {
            balance += deposit;
        }

        public static void Main()
        {
            mySavings myBank = new mySavings();
            double withdraw;
            double deposit;
            string choice;
            myBank.checkpin();

            do
            {
                Console.WriteLine("\n\nWELCOME TO BANK ATM SERVICE\n");
                Console.WriteLine("1. Current Balance\n");
                Console.WriteLine("2. Withdraw \n");
                Console.WriteLine("3. Deposit \n");
                Console.WriteLine("4. Cancel \n");
                Console.WriteLine("************************************\n\n");
                Console.WriteLine("ENTER YOUR CHOICE : ");
                choice = Console.ReadLine();

                if (choice == "1")
                {
                    myBank.getBal();
                    Console.WriteLine("\n YOUR CURRENT BALANCE IS Rs : {0} \n\n", myBank.getBal().ToString());
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (choice == "2")
                {
                    Console.WriteLine("\n ENTER THE WITHDRAW AMOUNT : ");
                    withdraw = int.Parse(Console.ReadLine());
                    myBank.goWith(withdraw);
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (choice == "3")
                {
                    Console.WriteLine("\n ENTER THE DEPOSIT AMOUNT");
                    deposit = int.Parse(Console.ReadLine());
                    myBank.goDep(deposit);
                    Console.WriteLine("YOUR AMOUNT HAS BEEN DEPOSITED SUCCESSFULLY..");
                    Console.WriteLine("YOUR TOTAL BALANCE IS Rs : {0}\n\n", myBank.getBal().ToString());
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                }

                else if (choice == "4")
                {
                    break;
                }

                else
                {
                    Console.WriteLine("Invalid Transaction\n");
                    Console.WriteLine("Press enter to continue");
                    Console.ReadLine();
                    Console.Clear();
                }
            }
            while (true);
            Console.WriteLine("Thank you");
            System.Environment.Exit(0);
        }
    }

}
