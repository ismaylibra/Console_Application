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
        public byte _limit;
        public int Limit;
        public Category Categories;
        public static int Count;
        public static int CountName;

        public List<Student> StudentsList = new List<Student>();
        public Group()
        {
            //StudentsList = new List<Student>();
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
            Limit = isonline ? 2 : 3;

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
                    _limit = 2;
                    if (_limit <= 3)
                    {
                        //StudentsList = new List<Student>(_limit);
                        //Console.WriteLine("Limit of online group is 15");
                    }
                    else
                    {
                        //Console.WriteLine("you cant create than 3");
                    }


                }
                else if (IsOnline)
                {
                    //if (_limit<=10)
                    //{

                    //    StudentsList = new List<Student>(_limit);
                    //    Console.WriteLine("Limit of offline group is 10");
                    //}
                    //else
                    //{
                    //    Console.WriteLine("you cant create than 10");
                    //}
                    _limit = 3;
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

