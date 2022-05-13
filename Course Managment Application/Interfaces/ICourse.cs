using System;
using System.Collections.Generic;
using System.Text;

namespace Course_Managment_Application.Interfaces
{
    interface ICourse
    {
        public List<Student> Students { get;  }
        public void CreateStudent();
        
    }
}
