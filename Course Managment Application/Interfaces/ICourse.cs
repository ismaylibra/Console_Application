using Course_Managment_Application.Enums;
using Course_Managment_Application.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Interfaces
{
    interface ICourse
    {
        public List<Group> Groups { get;  }
        public List<Student> Students { get; }
        public void CreateGroup(string no, Category category);
        public void EditGroup(string oldNumber, string newNumber);
        public void ShowListOfGroup(string no);
        
        public void ShowListofStudentsByGroup(string num);
        public void ShowListOfAllStudents(string no);
        public void CreateStudent(string name, string surname, string groupNo);
        public void RemoveStudent();
        
    }
}
