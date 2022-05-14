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
        
       public  List<Student> StudentsList = new List<Student>();
        public Group()
        {

        }
       
        public Group(string no, Category category)
        {
            No = no;
            IsOnline = false;
            Categories = category;
            Count = 0;
            Count++;
            
          
        }
        public byte LimitChecking {
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
       public  void StudentShow()
        {
            foreach (Student student in StudentsList)
            {
                Console.WriteLine(student);
            }
        }
        public void StudentInfo()
        {
            foreach (Student students in StudentsList)
            {
                Console.WriteLine($"Name and Surname: {students.FullName()} \nStudent ID: {students.Id} Category: {Categories} \nIs Guaranteed : {students.CheckPoint} \nIs Online: {LimitChecking}");
                
            }

        }
       
}


    }

