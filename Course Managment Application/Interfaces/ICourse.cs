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
        public void CreateGroup( Category category, bool isOnline);
        public void EditGroup(string oldNumber, string newNumber);
        public void ShowListOfGroup();
        
        public void ShowListofStudentsByGroup(string num);
        public void ShowListOfAllStudents();
        public void CreateStudent(string name, string surname, string groupNo, byte point);
        public void RemoveStudent(int id, string groupnum);
        
    }
}
