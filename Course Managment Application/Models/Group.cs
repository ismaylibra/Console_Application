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
        byte _limit;
        public Category Categories;
        public static int Count;
        public static int CountName;

        public List<Student> StudentsList;
        public Group()
        {
            StudentsList = new List<Student>();
        }

        static Group()
        {
            Count = 0;
            CountName = 1000;

        }
        public Group(Category category, bool isonline)
        {


            Categories = category;

            IsOnline = isonline;
            ++Count;
            CountName++;
            Count++;
            

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
        public byte LimitChecking
        {  
            get => _limit;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    StudentsList = new List<Student>(_limit);
                    Console.WriteLine("Limit of online group is 15");

                }
                else if (IsOnline)
                {
                    _limit = 10;
                    StudentsList = new List<Student>(_limit);
                    Console.WriteLine("Limit of offline group is 10");
                }
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
            return $"{No},{Categories}";
        }

    }


}

