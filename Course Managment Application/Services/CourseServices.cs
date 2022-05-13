using Course_Managment_Application.Enums;
using Course_Managment_Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using Course_Managment_Application.Models;


namespace Course_Managment_Application.Services
{
    class CourseServices : ICourse
    {
        List<Group> _groups = new List<Group>();
        public List<Group> Groups => _groups;

        public void CreateGroup(string no, Category category)
        {
            if (string.IsNullOrEmpty(no)|| string.IsNullOrWhiteSpace(no))
            {
                Console.WriteLine("Please, enter the Nº of Group. Nº of group can't be empty");
            }
            Group group = new Group(no, category);
            if (Group.Count==0)
            {
                _groups.Add(group);
                Console.WriteLine($"{group.No} successfully created");
            }
            foreach (Group existedGroup in Groups)
            {
                if (group.No.ToLower().Trim() != existedGroup.No.ToLower().Trim())
                {
                    _groups.Add(group);
                    Console.WriteLine($"{group.No} successfully created");
                }
            }
            Console.WriteLine("Group can not create");
        }


        public void EditGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowListOfAllStudents()
        {
            throw new NotImplementedException();
        }

        public void ShowListOfGroup()
        {
            throw new NotImplementedException();
        }

        public void ShowListofStudentsByGroup()
        {
            throw new NotImplementedException();
        }
    }
}
