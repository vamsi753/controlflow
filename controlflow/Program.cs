using System;

namespace controlflow
{
    class Program
    {
        static void Main(string[] args)
        {
            doApp();
        }

        static void doApp()
        {
          
            int number = 10;

          
            if (number > 5)
            {
                Console.WriteLine("Number is greater than 5.");
            }
            else
            {
                Console.WriteLine("Number is less than or equal to 5.");
            }

           
            switch (number)
            {
                case 5:
                    Console.WriteLine("Number is 5.");
                    break;
                case 10:
                    Console.WriteLine("Number is 10.");
                    break;
                default:
                    Console.WriteLine("Number is neither 5 nor 10.");
                    break;
            }
        

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("This is iteration " + i);
            }

          
            int whileCount = 0;
            while (whileCount < 3)
            {
                Console.WriteLine("Inside the while loop. Iteration " + whileCount);
                whileCount++;
            }

         
            int doWhileCount = 0;
            do
            {
                Console.WriteLine("Inside the do-while loop. Iteration " + doWhileCount);
                doWhileCount++;
            } while (doWhileCount < 3);
        }
    }
}
