using Course_Managment_Application.Enums;
using Course_Managment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;


namespace Course_Managment_Application.Services
{
    static class MenuService
    {
        public static CourseServices courseService = new CourseServices();
        public static void CreateGroupMenu()
        {
            Group group = new Group();
            string groupNo;
            object category;
            string answer;
            bool resultOnline;
            
           

            Console.WriteLine("Please, Enter The Group Number");
            groupNo = Console.ReadLine();
            Console.WriteLine("Please, Enter Which Category Do You Want To Study ");
            

            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }
            bool resultCategory = Enum.TryParse(typeof(Category), Console.ReadLine(), out category);

            Console.WriteLine("is it Group online");
            answer = Console.ReadLine();

            if(answer.ToLower().Trim() == "yes")
            {
                resultOnline = true;
                group.IsOnline = resultOnline;
            }
            else if (answer.ToLower().Trim() == "no")
            {
                resultOnline = false;
                group.IsOnline = resultOnline;
            }
            else
            {
                Console.WriteLine("Enter only yes or not fuck you");
            }
            if (resultCategory)
            {
                courseService.CreateGroup(groupNo,(Category)category,group.IsOnline);
            }
            


        }
    }
}
