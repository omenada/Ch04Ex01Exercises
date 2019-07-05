using System;

namespace Ch04Ex01
{
    class Program
    {
        static void Main(string[] args)
        {
            // operartorand();

            // Ch04Ex02();

            // Ch04Ex03();

            //calculation balance -- with DO WHILE
            //Ch04Ex04();

            //calculation balance -- with WHILE
            // Ch04Ex05();

            //LOOP USING FOR, WHILE AND SWITCH
            //Ch04Ex06();

            //Interrupting Loops

            InterruptingLoops();

        }

        static void operartorand()
        {

            Console.WriteLine("Enter an integer: ");
            int myint = Convert.ToInt32(Console.ReadLine());
            bool isLessThan10 = myint < 10;
            bool isBetween0and5 = (0 <= myint) && (myint <= 5);
            Console.WriteLine("Integer less than 10? {0}", isLessThan10);
            Console.WriteLine("Integer between 0 and 5? {0}", isBetween0and5);
            Console.WriteLine("Exactly || Just one of the above is true? {0}",
            isLessThan10 ^ isBetween0and5);
            Console.ReadKey();

        }

        static void Ch04Ex02 ()
        {
            string comparison;
            Console.WriteLine("Enter a number:");
            double var1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter another number:");
            double var2 = Convert.ToDouble(Console.ReadLine());
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }
            Console.WriteLine("The first number is {0} the second number.",
            comparison);
            Console.ReadKey();

        }

        static void Ch04Ex03()

        {
            const string myName = "karli";
            const string sexyName = "angelina";
            const string sillyName = "ploppy";
            string name;
            Console.WriteLine("What is your name?");
            name = Console.ReadLine();
            switch (name.ToLower())
            {
                case myName:
                    Console.WriteLine("You have the same name as me!");
                    break;
                case sexyName:
                    Console.WriteLine("My, what a sexy name you have!");
                    break;
                case sillyName:
                    Console.WriteLine("That's a very silly name.");
                    break;
            }
            Console.WriteLine("Hello {0}!", name);
            Console.ReadKey();

        }

        static void Ch04Ex04 ()

        {

            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?"); targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            do
            {
                balance *= interestRate;
                ++totalYears;
            }
            while (balance < targetBalance);
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
            totalYears, totalYears == 1 ? "" : "s", balance);
            Console.ReadKey();

        }

        static void Ch04Ex05()
        {

            double balance, interestRate, targetBalance;
            Console.WriteLine("What is your current balance?");
            balance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What is your current annual interest rate (in %)?");
            interestRate = 1 + Convert.ToDouble(Console.ReadLine()) / 100.0;
            Console.WriteLine("What balance would you like to have?");
            targetBalance = Convert.ToDouble(Console.ReadLine());
            int totalYears = 0;
            while (balance < targetBalance)
            {
                balance *= interestRate;
                ++totalYears;
            }
            Console.WriteLine("In {0} year{1} you'll have a balance of {2}.",
            totalYears, totalYears == 1 ? "" : "s", balance);
            if (totalYears == 0)
                Console.WriteLine(
                "To be honest, you really didn't need to use this calculator.");
            Console.ReadKey();

        }

        static void Ch04Ex06 ()
        {
            double realCoord, imagCoord;
            double realTemp, imagTemp, realTemp2, arg;
            int iterations;
            for (imagCoord = 1.2; imagCoord >= -1.2; imagCoord -= 0.05)
            {
                for (realCoord = -0.6; realCoord <= 1.77; realCoord += 0.03)
                {
                    iterations = 0;
                    realTemp = realCoord;
                    imagTemp = imagCoord;
                    arg = (realCoord * realCoord) + (imagCoord * imagCoord);
                    while ((arg < 4) && (iterations < 40))
                    {
                        realTemp2 = (realTemp * realTemp) - (imagTemp * imagTemp)
                        - realCoord;
                        imagTemp = (2 * realTemp * imagTemp) - imagCoord;
                        realTemp = realTemp2;
                        arg = (realTemp * realTemp) + (imagTemp * imagTemp);
                        iterations += 1;
                    }
                    switch (iterations % 4)
                    {
                        case 0:
                            Console.Write(".");
                            break;
                        case 1:
                            Console.Write("o");
                            break;
                        case 2:
                            Console.Write("O");
                            break;
                        case 3:
                            Console.Write("@");
                            break;
                    }

                    // to see each character printing out slowly.
                    System.Threading.Thread.Sleep(50);
                }
                Console.Write("\n");
            }
            Console.ReadKey();
            
        }

        static void InterruptingLoops()
        {
            //exemple 1
            int i = 1;
            while (i <= 10)
            {
                if (i == 6)
                    break;
                Console.WriteLine("{0}", i++);
            }

            //exemple 2
            int i;
            for (i = 1; i <= 10; i++)
            {
                if ((i % 2) == 0)
                    continue;
                Console.WriteLine(i);
            }

            //exemple 3
            int i = 1;
            while ( i <= 10)
            {
                if (i == 6)
                    goto exitPoint;
                Console.WriteLine("{0}", i++);
            }

            Console.WriteLine("This code will never be reached.");
            
            //label function 
            exitPoint:
            Console.WriteLine("This code is run when the loop is exited using goto.");

        }
    }
}
