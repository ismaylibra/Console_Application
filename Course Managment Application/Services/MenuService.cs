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
            //string groupNo;
            object category;
            byte answer;
           


            //Console.WriteLine("Please, Enter The Group Number");
            //groupNo = Console.ReadLine();
            Console.WriteLine("Please, Enter Which Category Do You Want To Study ");
            

            foreach (var item in Enum.GetValues(typeof(Category)))
            {
                Console.WriteLine($"{(int)item}. {item}");
            }
            bool resultCategory = Enum.TryParse(typeof(Category), Console.ReadLine(), out category);

            Console.WriteLine("is it Group online");
            Console.WriteLine("1.Yes \n2.No");
            answer = Convert.ToByte(Console.ReadLine());

            if (answer == 1)
            {
                
                group.IsOnline = true;
            }
            else if (answer==2)
            {
                
                group.IsOnline = false;
            }
           
            if (resultCategory)
            {
                courseService.CreateGroup((Category)category,group.IsOnline);
            }
            


        }
        public static void EditGroupMenu()
        {
            Console.WriteLine("Please, enter Group No");
            string num = Console.ReadLine();
            Console.WriteLine("Please, enter New Group No");
            string newNum = Console.ReadLine();
            courseService.EditGroup(num, newNum);
        }
        public static void ShowListOfAllStudentsMenu()
        {
            courseService.ShowListOfAllStudents();
        }
        public static void ShowListofStudentsByGroupMenu()
        {
            Console.WriteLine("Enter Group Number");
            string groupNumber = Console.ReadLine();
            courseService.ShowListofStudentsByGroup(groupNumber);
        }
        public static void ShowListOfGroupMenu()
        {
            courseService.ShowListOfGroup();
        }
        public static void CreateStudentMenu()
        {
            Console.WriteLine("Enter the Name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter the Surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Enter the Group Number");
            string groupNum = Console.ReadLine();
            Console.WriteLine("Enter Your Entry Point");
            byte point = Convert.ToByte(Console.ReadLine());
            courseService.CreateStudent(name,surname,groupNum,point);
       }
       

        public static void RemoveStudentMenu()
        {
            Console.WriteLine("Please , enter name");
            string name = Console.ReadLine();
            Console.WriteLine("Please, enter surname");
            string surname = Console.ReadLine();
            Console.WriteLine("Please, Enter group num");
            string groupnum = Console.ReadLine();

            courseService.RemoveStudent(name, surname,groupnum);
        }
    } 
}
