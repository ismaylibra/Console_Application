﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application
{
    class Student
    {
        public int Id;
        public string Name;
        public string Surname;
        public string GroupNo;
        byte _point;
        bool _guaranteed;
        public static int count;
        public static int countId;
        public byte CheckPoint
        {
            get => _point;
            set
            {
                if (value>80)
                {
                    Console.WriteLine("You are a guaranteed student ");
                    _point = value;
                    _guaranteed = true;
                }
                else if (value<=80)
                {
                    Console.WriteLine("You are a student without a guarantee");
                    _point = value;
                    _guaranteed = false;
                }
            }
        }

        static Student()
        {
            count = 0;
            countId = 1;
            
           
        }
      
        public Student(string name, string surname, string groupNo)
        {
            
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Id = countId;
            countId++;
            count++;
        }
        public  string FullName()
        {
            return $"Name: {Name} Surname: {Surname}";
        }
      
        
        
        

    }


}
