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
        List<Student> _studentsList = new List<Student>();
       
        public Group(string no, Category category)
        {
            No = no;
            IsOnline = false;
            Categories = category;
            Count = 0;
            Count++;
            
          
        }
        public List<Student> LimitChecking {
            get => _studentsList;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    _studentsList = new List<Student>(_limit);
                    Console.WriteLine("Limit of online group is 15");
                    
                }
                else if (IsOnline)
                {
                    _limit = 10;
                    _studentsList = new List<Student>(_limit);
                    Console.WriteLine("Limit of offline group is 10");
                }
            }
            }
       public  void StudentShow()
        {
            foreach (Student student in _studentsList)
            {
                Console.WriteLine(student);
            }
        }
        public void StudentInfo()
        {
            foreach (Student students in _studentsList)
            {
                Console.WriteLine($"Name and Surname: {students.FullName()} \nStudent ID: {students.Id} Category: {Categories} \nIs Guaranteed : {students.CheckPoint} \nIs Online: {LimitChecking}");
                
            }

        }
       
}


    }

