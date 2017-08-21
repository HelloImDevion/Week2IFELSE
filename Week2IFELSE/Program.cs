using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2IFELSE
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Console.WriteLine("Enter age :");

            //    int age = int.Parse(Console.ReadLine());
            //    if(age >= 17)
            //    {
            //        Console.WriteLine("you can see the movie ");
            //    }
            //    else
            //    {
            //        Console.WriteLine("You cant see the movie ");
            //    }

            //    }
            //Console.lwriteLine ("Enter your percentange")
            //    int grade = int.Parse(Console.ReadLine());
            //if(grade >= 90 && <= 100)


            //The Questions I asked
            Console.WriteLine("Enter how many Dinners there are: ");
            double amountofDinners = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter how much per dinner: ");
            double costofDinners = double.Parse(Console.ReadLine());

            // The total multiplacation
            double totalCost = amountofDinners * costofDinners;

            // The discount math
            double tenDiscount = totalCost * 0.10;
            double afterTenDiscount = totalCost - tenDiscount;

            double fiveDiscount = totalCost * 0.05;
            double afterFiveDiscount = totalCost - fiveDiscount; 

            // Splitting the bill math
            double eachPersonPaysTen = afterTenDiscount / amountofDinners;
            double eachPersonPaysFive = afterFiveDiscount / amountofDinners;


            //The if else statment with the final solution in it 
            if (totalCost >= 50.00)
            {
                Console.WriteLine("You get a 10% discount!!!");
                Console.WriteLine("Your original amount was " + "$" + totalCost);
                Console.WriteLine("Your amount now is " + "$" + afterTenDiscount);
                Console.WriteLine("Recommended each person should pay " + "$" + eachPersonPaysTen);
            }

            else
            {
                Console.WriteLine("You get a 5% discount!!!");
                Console.WriteLine("Your original amount was " + "$" + totalCost);
                Console.WriteLine("Your New amount is " + "$" + afterFiveDiscount);
                Console.WriteLine("Recommended each person should pay " + "$" + eachPersonPaysFive);
            }

          



            //int mikeBill = 13;
            //int friendBill = 13;
            //int friend2Bill = 13;
            //int friend3Bill = 13;
            //int totalAge = mikeBill + friendBill + friend2Bill + friend3Bill;
            //Console.WriteLine(totalAge);

        }

    }
    
}
