using System;

namespace _13._25._10._2021_home_task
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task: 1-dən 100-ə qədər ədədləri console-da çap edin
            //
            //for(int i = 1; i < 100; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //Task: 1-dən 100-ə qədər tək ədədləri console-da çap edin
            //
            //for (int i = 1; i < 100; i++)
            //{
            //    if(i % 2 == 1)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task: User tərəfindən daxil edilmiş ədədin 2 mislini(2-yə vurmaq) console-da çap edin
            //
            //int num = int.Parse(Console.ReadLine());
            //Console.WriteLine(num * 2);

            //Task: 1
            //
            //for(int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + " ");
            //}

            //Task: 2
            //
            //int sum = 0;
            //Console.WriteLine("The first 10 natural numbers are:");
            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.Write(i + " ");
            //    sum += i;
            //}
            //Console.WriteLine("\nThe Sum is: " + sum);

            //Task: 3
            //
            //Console.Write("Input the radius of the circle: ");
            //int radius = int.Parse(Console.ReadLine());
            //double perimeter = 2 * Math.PI * radius;
            //double area = Math.PI * Math.Pow(radius, 2);
            //Console.WriteLine("Perimeter of circle: " + Math.Round(perimeter, 2));
            //Console.WriteLine("Area of circle: " + Math.Round(area, 2));

            //Task: 4
            //
            //Console.Write("Input first number: ");
            //int number1 = int.Parse(Console.ReadLine());
            //Console.Write("Input operation: ");
            //string operand = Console.ReadLine();
            //Console.Write("Input second number: ");
            //int number2 = int.Parse(Console.ReadLine());
            //switch(operand)
            //{
            //    case "+":
            //        Console.WriteLine(number1 + " + " + number2 + " = " + (number1 + number2));
            //        break;
            //    case "-":
            //        Console.WriteLine(number1 + " - " + number2 + " = " + (number1 - number2));
            //        break;
            //    case "*":
            //        Console.WriteLine(number1 + " * " + number2 + " = " + (number1 * number2));
            //        break;
            //    case "/":
            //        Console.WriteLine(number1 + " / " + number2 + " = " + (number1 / number2));
            //        break;
            //    case "%":
            //        Console.WriteLine(number1 + " % " + number2 + " = " + (number1 % number2));
            //        break;
            //    default:
            //        Console.WriteLine("Invalid operator!");
            //        break;
            //}

            //Task: 5
            //
            //Console.Write("Enter a number: ");
            //int num = int.Parse(Console.ReadLine());
            //Console.Write("Enter the desired width: ");
            //int width = int.Parse(Console.ReadLine());

            //for (int i = width; i > 0; i--)
            //{
            //    for(int j = i; j > 0; j--)
            //    {
            //        Console.Write(num + " ");
            //    }
            //    Console.WriteLine();
            //}

            //Task: 6
            //
            string username = "murad", username_input = "";
            string password = "hajiyev", password_input = "";
            int wrong_try = 0;
            do
            {
                Console.Write("Enter your username: ");
                username_input = Console.ReadLine();
                if (username == username_input)
                {
                    wrong_try = 0;
                    do
                    {
                        Console.Write("Enter your password: ");
                        password_input = Console.ReadLine();
                        if (password == password_input)
                        {
                            break;
                        } else
                        {
                            wrong_try++;
                        }
                    } while (wrong_try != 3);
                    break;
                }
                else
                {
                    wrong_try++;
                }
            } while (wrong_try != 3);
            if(wrong_try < 3)
            {
                Console.WriteLine("You have entered successfully!");
            } else
            {
                Console.WriteLine("Username or password is not valid!");
            }
        }
    }
}
