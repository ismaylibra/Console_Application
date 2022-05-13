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
        public void CreateGroup(string no, Category category);
        public void EditGroup();
        public void ShowListOfGroup();
        
        public void ShowListofStudentsByGroup();
        public void ShowListOfAllStudents();

        
    }
}
