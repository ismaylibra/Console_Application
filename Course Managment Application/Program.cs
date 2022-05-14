using Course_Managment_Application.Enums;
using Course_Managment_Application.Services;
using System;

namespace Course_Managment_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Welcome to our Course Applicatiion");
            int choice = default;
            do
            {
                Console.WriteLine("1.Create a New Group");
                Console.WriteLine("2.Show List Of All Groups in Course");
                Console.WriteLine("3.Group Editing");
                Console.WriteLine("4.Show List Of Students in Group");
                Console.WriteLine("5.Show List Of All Students in Course");
                Console.WriteLine("6.Add New Student");
                Console.WriteLine("7.Remove Student");
                Console.WriteLine("0.Exit");
                
                bool result = int.TryParse(Console.ReadLine(), out choice);
                Console.Clear();
                if (result)
                {
                    switch (choice)
                    {
                        case 1:
                            MenuService.CreateGroupMenu();
                            break;
                            
                        default:
                            break;
                    }
                }

            } while (choice!=0);
            

        }
    }
}
