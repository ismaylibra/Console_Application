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
        List<Student> _students = new List<Student>();
        public List<Group> Groups => _groups;

        public List<Student> Students => _students;

        public void CreateGroup(string no, Category category, bool isOnline)
        {
            
            if (string.IsNullOrEmpty(no) || string.IsNullOrWhiteSpace(no))
            {
                Console.WriteLine("Please, enter the  Group Nº .Group Nº can't be empty");


            }
            Group group = new Group(no, category, isOnline);
            if (Group.Count >= 0)
            {
                _groups.Add(group);
                Console.WriteLine(" successfully created"); 
            }
            else if(Group.Count!=0)
            {
                foreach (Group existedGroup in Groups)
                {
                    if (group.No.ToLower().Trim() != existedGroup.No.ToLower().Trim())
                    {
                        _groups.Add(group);
                        Console.WriteLine("created");
                    }
                    else
                    {
                        Console.WriteLine("Group already created");
                    }
                }
            }
            
            
        }
        public Group FindGroup(string no)
        {
            foreach (Group groups in Groups)
            {
                if (groups.No.ToLower().Trim()== no.ToLower().Trim())
                {
                    return groups;
                }
            }
            return null;
        }

        public void EditGroup(string oldNumber, string newNumber)
        {
            if (FindGroup(newNumber) == null)
            {
                Group group = FindGroup(oldNumber);
                if (group != null)
                {
                    group.No = newNumber.ToLower().Trim();
                    Console.WriteLine($"{group.No} successfully created");
                }
                else
                {
                    Console.WriteLine($"There is no group {oldNumber.ToUpper()}");
                }
            }
            else
            {
                Console.WriteLine($"There is a group {newNumber.ToUpper()}");
            }
        }

        public void ShowListOfAllStudents()
        {
            if (Student.count>0)
            {
                foreach (Student students in Students)
                {
                    Console.WriteLine(students);
                }
            }
            else
            {
                Console.WriteLine("There is no student");
            }
        }

       

        public void ShowListofStudentsByGroup(string num)
        {
            Group group = FindGroup(num);
            if (group == null)
            {
                foreach (Student students in group.StudentsList)
                {
                    Console.WriteLine(students);
                }
            }
            else
            {
                Console.WriteLine("There is no Student in Group");
            }
        }

        public void CreateStudent(string name, string surname, string groupNo,byte point)
        {
        
            if (Group.Count>0)
            {
                Student student = new Student(name,surname,groupNo,point);
                if (string.IsNullOrEmpty(student.FullName()) || string.IsNullOrWhiteSpace(student.FullName()))
                {
                    Console.WriteLine("Student can not created");
                }
                else
                {
                    
                    
                    Console.WriteLine($"Name: {name} Surname: {surname} Group Number{groupNo}");
                    Students.Add(student);
                    Group group = new Group();
                    group.StudentsList.Add(student);
                }
            }
            else
            {
                Console.WriteLine("You can not add student in group. Because this group is not found");
            }
        }
      

        public void RemoveStudent()
        { Student student = new Student();
            if (student==null)
            {
                Console.WriteLine("This student is not found");
            }
            else
            {

                _students.Remove(student);
            }
        }

        public void ShowListOfGroup(string no)
        {
            if (Group.Count > 0)
            {
                foreach (Group groups in Groups)
                {
                    Console.WriteLine(groups);
                }
            }
            else
            {
                Console.WriteLine("There is no group");
            }
        }
    }
}
