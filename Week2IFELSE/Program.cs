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


            ////The Questions I asked
            //Console.WriteLine("Enter how many Dinners there are: ");
            //double amountofDinners = double.Parse(Console.ReadLine());
            //Console.WriteLine("Enter how much per dinner: ");
            //double costofDinners = double.Parse(Console.ReadLine());

            //// The total multiplacation
            //double totalCost = amountofDinners * costofDinners;

            //// The discount math
            //double tenDiscount = totalCost * 0.10;
            //double afterTenDiscount = totalCost - tenDiscount;

            //double fiveDiscount = totalCost * 0.05;
            //double afterFiveDiscount = totalCost - fiveDiscount;

            //// Splitting the bill math
            //double eachPersonPaysTen = afterTenDiscount / amountofDinners;
            //double eachPersonPaysFive = afterFiveDiscount / amountofDinners;


            ////The if else statment with the final solution in it 
            //if (totalCost >= 50.00)
            //{
            //    Console.WriteLine("You get a 10% discount!!!");
            //    Console.WriteLine("Your original amount was " + "$" + totalCost);
            //    Console.WriteLine("Your amount now is " + "$" + afterTenDiscount);
            //    Console.WriteLine("Recommended each person should pay " + "$" + eachPersonPaysTen);
            //}

            //else
            //{
            //    Console.WriteLine("You get a 5% discount!!!");
            //    Console.WriteLine("Your original amount was " + "$" + totalCost);
            //    Console.WriteLine("Your New amount is " + "$" + afterFiveDiscount);
            //    Console.WriteLine("Recommended each person should pay " + "$" + eachPersonPaysFive);
            //}


            //Console.WriteLine("How old are you ?");
            //int personAge = int.Parse( Console.ReadLine());

            //if (personAge >= 0 && personAge <= 2)
            //{
            //    Console.WriteLine("Still in Mama's Arms");
            //}
            //else if(personAge >= 3 && personAge <= 4)
            //{
            //    Console.WriteLine("Preschool Maniac");
            //}
            //else if(personAge >= 5 && personAge <= 11)
            //{
            //    Console.WriteLine("Elementary School");
            //}
            //else if(personAge >= 12 && personAge <= 14)
            //{
            //    Console.WriteLine("Middle School");
            //}
            //else if (personAge >= 15 && personAge <= 18)
            //{
            //    Console.WriteLine("High School");
            //}
            //else if (personAge >= 19 && personAge <= 22)
            //{
            //    Console.WriteLine("College");
            //}
            //else if (personAge >= 23 && personAge <= 65)
            //{
            //    Console.WriteLine("Working for the Man");
            //}
            //else if (personAge >= 66 && personAge <= 100)
            //{
            //    Console.WriteLine("The Golden Years");
            //}
            //else
            //{
            //    Console.WriteLine("This Program is for humans");
            //}

            Console.WriteLine("Enter a number to see if its even or old.");
            int input = int.Parse(Console.ReadLine());

            switch (Math.Abs(input) % 2)
            {
                case 0:
                case 2:
                case 4:
                case 6:
                case 8:
                    Console.WriteLine("Even");
                    break;
                default:
                    Console.WriteLine("Odd");
                    break;
            }




        }

    }
    
}
