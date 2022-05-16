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
            object category;
            byte answer;
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
        { string name;
          string surname;
          string groupNum;
          byte point;
            do
            {
                Console.WriteLine("Enter the Name");
                name = Console.ReadLine();
               
            } while (string.IsNullOrEmpty(name)||string.IsNullOrWhiteSpace(name));
            do
            {
                Console.WriteLine("Enter the Surname");
                surname = Console.ReadLine();
            } while (string.IsNullOrEmpty(surname) || string.IsNullOrWhiteSpace(surname));
            do
            {
                Console.WriteLine("Enter the Group Number");
                groupNum = Console.ReadLine();
            } while (string.IsNullOrEmpty(groupNum) || string.IsNullOrWhiteSpace(groupNum));
            
            Console.WriteLine("Enter Your Entry Point");
            bool resultPoint = byte.TryParse(Console.ReadLine(), out point);
            courseService.CreateStudent(name, surname, groupNum, point);


        }


        public static void RemoveStudentMenu()
        {
            Console.WriteLine("Please enter student id");
            Student.countId = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please, Enter group num");
            string groupnum = Console.ReadLine();

            courseService.RemoveStudent(Student.countId, groupnum);
        }
    }
}
