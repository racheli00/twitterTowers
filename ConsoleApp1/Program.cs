using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int userChoice = 0, width=0, height=0;
            Console.WriteLine("Press 1 for rectangle\nPress 2 for triangle\nPress 3 to end");
            userChoice = int.Parse(Console.ReadLine());
            while (userChoice != 3)
            {
                if (userChoice != 1 && userChoice != 2) //wrong choice
                {
                    Console.WriteLine("Wrong number");
                    goto next;
                }

                Console.WriteLine("Enter width please:");
                width = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter height please:");
                height = int.Parse(Console.ReadLine());

                if (userChoice == 1)//rectangle choice
                {
                    if (Math.Abs(width-height)>5)
                        Console.WriteLine("Its area is: "+width*height);
                    else
                        Console.WriteLine("Its perimeter is: " + ((width*2) +(height*2)));
                }
                else //triangle choice
                {
                    wrongNum:
                    Console.WriteLine("Press 1 for perimeter\nPress 2 for printing the triangle");
                    userChoice = int.Parse(Console.ReadLine());
                    if (userChoice==1)
                    {
                       double perimeter = Math.Sqrt(Math.Pow((float)width / 2, 2) + Math.Pow((float)height, 2));
                       Console.WriteLine("Its perimeter is: " + perimeter);
                    }

                    else if(userChoice == 2)
                    {
                        if (width%2==0 || width>=(height*2))
                            Console.WriteLine("The triangle can't be printed, sorry");
                        else //print the triangle
                        {
                            int betweenNums = width / 2 - 1;
                            int betweenRows = height - 2;
                            int spaces = width / 2;
                            int currerntRow = 1;
                            string line = new string(' ', spaces) + '*';
                            Console.WriteLine(line);
                            for (int i = 0; i < betweenNums; i++)
                            {
                                int j;
                                int rowsPerNum = betweenRows / betweenNums;
                                currerntRow += 2;
                                spaces--;
                                line = new string(' ', spaces) + new string('*', currerntRow);
                                if (i == 0)
                                {
                                    int extraRows = betweenRows % betweenNums;
                                    if (extraRows > 0)
                                        for (j = 0; j < extraRows; j++)
                                            Console.WriteLine(line);
                                }

                                for (j = 0; j < rowsPerNum; j++)
                                    Console.WriteLine(line);
                            }
                            line = new string('*', width);
                            Console.WriteLine(line);
                        }
                    }
                    else 
                    {
                        Console.WriteLine("Wrong choice");
                        goto wrongNum;
                    }
                }

                next:
                    Console.WriteLine("Press 1 for rectangle\nPress 2 for triangle\nPress 3 to end");
                    userChoice = int.Parse(Console.ReadLine());
            }
        }
    }
}
