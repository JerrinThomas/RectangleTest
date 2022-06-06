using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/**
 * Assignment 2
 * Jerrin Thomas
 * 8770668
 */
namespace Assignment02
{
    class Program
    {
        public static void Main(string[] args)
        {
            // Initialising the rectangle class object and other variables.
            Rectangle rectangle = new Rectangle();
            int rectangleLength = 0, rectangleWidth = 0;
            Boolean isInputValid = false;

            // Prompting the user for initial length of the rectangle.
            do
            {
                Console.WriteLine("Enter the rectangle length : ");
                string lengthRectangle = Console.ReadLine();
                int.TryParse(lengthRectangle, out rectangleLength);

                if (!(rectangleLength > 0))
                {
                    Console.WriteLine("Enter a value for length greater than zero!\n");
                    isInputValid = false;
                }
                else
                {
                    rectangle.SetLength(rectangleLength);
                    isInputValid = true;
                }
            } while (!isInputValid);

            isInputValid = false;

            // Prompting the user for initial width of the rectangle.
            do
            {
                Console.WriteLine("Enter the rectangle width : ");
                string widthRectangle = Console.ReadLine();
                int.TryParse(widthRectangle, out rectangleWidth);

                if (!(rectangleWidth > 0))
                {
                    Console.WriteLine("Enter a value for width greater than zero!\n");
                    isInputValid = false;
                }
                else
                {
                    rectangle.SetWidth(rectangleWidth);
                    isInputValid = true;
                }
            } while (!isInputValid);

            int choice = 0;
            do
            {
                // Display the menu to the user.
                do
                {
                    Console.Write("1.Get Rectangle Length \n");
                    Console.Write("2.Change Rectangle Length\n");
                    Console.Write("3.Get Rectangle Width\n");
                    Console.Write("4.Change Rectangle Width \n");
                    Console.Write("5.Get Rectangle Perimeter\n");
                    Console.Write("6.Get Rectangle Area\n");
                    Console.Write("7.Exit\n");
                    Console.Write("Enter your choice : ");
                    choice = Convert.ToInt32(Console.ReadLine());
                } while ((choice <= 0) || (choice >= 8));
                try
                {
                    switch (choice)
                    {

                        case 1:
                            {
                                Console.WriteLine("\nLength of the rectangle is : {0}", rectangle.GetLength());
                                break;
                            }
                        case 2:
                            {
                                int updatedLength = 0;
                                do
                                {
                                    Console.Write("Enter the new value for length : ");
                                    int.TryParse(Console.ReadLine(), out updatedLength);
                                    // Check if the length is greater than zero.
                                    if (updatedLength > 0)
                                    {
                                        rectangle.SetLength(updatedLength);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a length greater than zero");
                                    }
                                } while (updatedLength <= 0);

                                break;
                            }
                        case 3:
                            {
                                Console.WriteLine("\n Width of the rectangle is : {0} ", rectangle.GetWidth());
                                break;
                            }
                        case 4:
                            {
                                int updatedWidth = 0;
                                do
                                {
                                    Console.Write("Enter the new value for width : ");
                                    int.TryParse(Console.ReadLine(), out updatedWidth);
                                    // Check if the width is greater than zero.
                                    if (updatedWidth > 0)
                                    {
                                        rectangle.SetWidth(updatedWidth);
                                    }
                                    else
                                    {
                                        Console.WriteLine("Enter a width greater than zero");
                                    }

                                } while (updatedWidth <= 0);
                                break;
                            }
                        case 5:
                            {
                                int perimeter = rectangle.GetPerimeter();

                                Console.WriteLine("The Perimeter of the rectangle is : {0}", perimeter);
                                break;
                            }
                        case 6:
                            {
                                int area = rectangle.GetArea();

                                Console.WriteLine("The Area of the rectangle is : {0}", area);
                                break;
                            }
                        case 7:
                            {
                                break;
                            }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            while (choice != 7);
        }
    }
}
