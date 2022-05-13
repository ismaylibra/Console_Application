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
        List<Student> _StudentsList = new List<Student>();
        public Group(string no, Category category)
        {
            No = no;
            IsOnline = false;
            Categories = category;
          
        }
        public List<Student> Students  {
            get => _StudentsList;
            set
            {
                if (!IsOnline)
                {
                    _limit = 15;
                    _StudentsList = new List<Student>(_limit);
                    
                }
                else if (IsOnline)
                {
                    _limit = 10;
                    _StudentsList = new List<Student>(_limit);
                }
            }
            }
        public void Student()
        {
            foreach (Student students in _StudentsList)
            {
                Console.WriteLine($"Name and Surname: {students.FullName()} \nStudent ID: {students.Id} Category: {Categories} \nIs Guaranteed : {students.CheckPoint} \nIs Online: {Students}");
                
            }

        }
       
}


    }

