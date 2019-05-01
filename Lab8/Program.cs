using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    class Program
    {
        static void Main(string[] args)
        {


            string[] people = { "Tony", "Joe", "Dan", "Kyle", "Jack" };
            string[] food = { "Pasta", "Steak", "Cheeseburgers", "Salad", "Sushi" };
            string[] hometown = { "Saint Clair Shores", "Romeo", "Washington", "Shelby Twp", "Detroit" };
            string response = "y";
                                          
            Console.WriteLine("Welcome to our C# class. ");

            while(response == "y")
            { 
            Console.WriteLine("Which student would you like to learn more about? (enter a number 1-5): ");
            int number = int.Parse(Console.ReadLine());
            try
            {
                UserNumber(number);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            for (int i = 0; i < people.Length; i++)
            {


                    if (i == number - 1)
                    {
                        Console.WriteLine($"Student {number} is {people[i]} ");
                        Console.WriteLine($"What Would you like to know about {people[i]}? (Enter hometown or favorite food)");

                        string choice = Console.ReadLine();

                        try
                        {
                            if (choice == "hometown")
                            {
                                Console.WriteLine($"{people[i]} is from {hometown[i]}");
                                Console.WriteLine("Would you like to know more? Enter yes or no: ");

                                string selection = Console.ReadLine();
                                if (selection == "yes")
                                {
                                    Console.WriteLine($"{people[i]}'s favorite food is {food[i]} ");
                                }
                                else
                                {
                                    Console.WriteLine("Thanks");
                                    break;
                                }


                            }
                            else if (choice == "favorite food")
                            {
                                Console.WriteLine($"{people[i]}'s favorite food is {food[i]}");
                                Console.WriteLine("Would you like to know more? Enter yes or no: ");
                                string selection = Console.ReadLine();

                                if (selection == "yes")
                                {
                                    Console.WriteLine($"{people[i]} is from {hometown[i]} ");
                                }
                                else
                                {
                                    Console.WriteLine("Thanks");
                                    break;
                                }


                            }
                            else
                            {
                                throw new Exception("INVALID INPUT, please input hometown or favorite food!!!");
                            }


                        }
                        catch (Exception e1)
                        {
                            Console.WriteLine(e1.Message);
                        }
                        Console.WriteLine("Do you want to start again? (y or no) ");
                        response = Console.ReadLine();
                    }
                    

                   
                  


                       
                    
                }
               
            }
        }
        
        public static int UserNumber(int number)
        {
            if(number > 5 || number < 1)
            {
                throw new Exception("Number must be between 1 and 5.");
            }
            else
            {
                return number;
            }

            
        }






















    }   




    
}
