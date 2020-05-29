using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Assignment Number: ");
            string switch_on = Console.ReadLine();
            switch (switch_on)
            {
                case "1":
                    Assignment1();
                    break;
                case "2":
                    Assignment2();
                    break;
                case "3":
                    Assignment3();
                    break;
                case "4":
                    Assignment4();
                    Assignment4_1();
                    break;
                case "5":
                    Assignment5();
                    break;
                default:
                    Console.WriteLine("Wrong Input");
                    break;


            }
            Console.ReadLine();
        }

       
        private static void Assignment5()
        {
            Console.WriteLine(first_last("w3resource"));
            Console.WriteLine(first_last("Python"));
            Console.WriteLine(first_last("x"));
            
        }
        public static string first_last(string ustr)
        {
            return ustr.Length > 1
                ? ustr.Substring(ustr.Length - 1) + ustr.Substring(1, ustr.Length - 2) + ustr.Substring(0, 1) : ustr;
        }

        private static void Assignment4()
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}{0}{0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0} {0}", x);
            Console.WriteLine("{0}{0}{0}", x);

        }

        private static void Assignment4_1()
        {
            int x;

            Console.Write("Enter a number: ");
            x = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= 5; i++)
            {
                if (i == 1 | i == 5)
                {
                    Console.WriteLine("{0}{0}{0}", x);

                }
                else
                {
                    Console.WriteLine("{0} {0}", x);

                }
            }

        }


        public static void Assignment3()
        {
            Console.Write("Enter a number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0} + {1} = {2}", num1, num2, num1 + num2);
            Console.WriteLine("{0} - {1} = {2}", num1, num2, num1 - num2);
            Console.WriteLine("{0} x {1} = {2}", num1, num2, num1 * num2);
            Console.WriteLine("{0} / {1} = {2}", num1, num2, num1 / num2);
            Console.WriteLine("{0} mod {1} = {2}", num1, num2, num1 % num2);
        }

        private static void Assignment2()
        {
            int num1, num2, num3;

            Console.Write("Input the first number to multiply: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the second number to multiply: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Input the third number to multiply: ");
            num3 = Convert.ToInt32(Console.ReadLine());

            int result = num1 * num2 * num3;
            Console.WriteLine("Output: {0} x {1} x {2} = {3}",
                                num1, num2, num3, result);
        }

        public static void Assignment1()
        {
            int number1, number2, temp;
            Console.Write("\nInput the First Number : ");
            number1 = int.Parse(Console.ReadLine());
            Console.Write("\nInput the Second Number : ");
            number2 = int.Parse(Console.ReadLine());
            temp = number1;
            number1 = number2;
            number2 = temp;
            Console.Write("\nAfter Swapping : ");
            Console.Write("\nFirst Number : " + number1);
            Console.Write("\nSecond Number : " + number2);
            Console.Read();
        }

    }
}
