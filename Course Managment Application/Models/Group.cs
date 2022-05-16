using Course_Managment_Application.Enums;

using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Models
{
    class Group
    {
        public string No;
        public bool IsOnline;
        public int Limit;
        public Category Categories;
        public static int Count;
        public static int CountName;

        public List<Student> StudentsList = new List<Student>();
        public Group()
        {
            
        }

        static Group()
        {
            Count = 0;
            CountName = 1000;

        }
        public Group(Category category, bool isOnline)
        {
            Categories = category;
            IsOnline = isOnline;
            ++Count;
            CountName++;
            Count++;
            Limit = isOnline ? 15 : 10;

            switch (category)
            {
                case Category.Programming:
                    No = $"P-" + CountName;
                    break;
                case Category.Design:
                    No = $"D-" + CountName;
                    break;
                case Category.System_Administration:
                    No = $"SA-" + CountName;
                    break;
                default:
                    break;
            }


        }
       
       
        public void StudentShow()
        {
            foreach (Student student in StudentsList)
            {
                Console.WriteLine(student);
            }
        }


        public override string ToString()
        {
            if (IsOnline==true)
            {
                return $"Group No: {No} Category: {Categories} This  Group is Online";
            }
            return $"Group No: {No} Category: {Categories} This Group is Offline";
        }

    }


}

