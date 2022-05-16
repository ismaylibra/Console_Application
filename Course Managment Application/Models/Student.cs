using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application
{
    class Student
    {
        public uint Id;
        public string Name;
        public string Surname;
        public string GroupNo;
        byte _point;
        bool _guaranteed;
        public static uint count;
        public static int countId;
        public byte CheckPoint
        {
            get => _point;
            set
            {
                if (value>80)
                {
                    Console.WriteLine("You are a guaranteed student  ");
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
            count = default; 
           
        }
        public Student()
        {
             
        }
      
        public Student(string name, string surname, string groupNo, byte point)
        {
            
            Name = name;
            Surname = surname;
            GroupNo = groupNo;
            Id = ++count;
            CheckPoint = point;
            
        }
        public  string FullName()
        {
            return $"Name: {Name} Surname: {Surname}";
        }
        
        public override string ToString()
        {
            return $"Student Info {FullName()}\n Group No: {GroupNo} \n Is Guarantee: {CheckPoint}  {_guaranteed} \nIs Online {CheckPoint} \nStudent ID: {Id} ";
        }



    }


}
