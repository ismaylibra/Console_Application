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



        public void CreateGroup(Category category, bool isOnline)
        {

            Group group = new Group(category, isOnline);
            _groups.Add(group);
            Console.WriteLine(group);

        }
        public Group FindGroup(string no)
        {
            foreach (Group groups in Groups)
            {
                if (groups.No.ToLower().Trim() == no.ToLower().Trim())
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
                Console.WriteLine($"There is already exist {newNumber.ToUpper()}");
            }
        }

        public void ShowListOfAllStudents()
        {
            if (Student.count > 0)
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
            if (group != null)
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

        public void CreateStudent(string name, string surname, string groupNo, byte point)
        {


            if (Group.Count > 0)
            {

                Student student = new Student(name, surname, groupNo, point);
                if (string.IsNullOrEmpty(student.FullName()) || string.IsNullOrWhiteSpace(student.FullName()))
                {
                    Console.WriteLine("Student can not created");
                }
                else
                {
                    //Group group = _groups.Find(x => x.No == groupNo);
                    Group group = GetGroup(groupNo);

                    if (group == null)
                    {
                        Console.WriteLine("Group not found");
                        return;
                    }

                    if (group.StudentsList.Count >= group.Limit)
                    {
                        Console.WriteLine("olmaz");
                        return;
                    }
                    Console.WriteLine($"Name: {name} Surname: {surname} Group Number{groupNo}");

                  
                    //group.StudentsList = new List<Student>();
                    group.StudentsList.Add(student);
                }
            }
            else
            {
                Console.WriteLine("You can not add student in group. Because this group is not found");
            }
        }


        Group GetGroup(string groupNo)
        {
            foreach (Group group in _groups)
            {
                if (group.No==groupNo)
                {
                    return group;
                }
            }
            return null;
        }
        public void RemoveStudent(string name, string surname, string groupnum)
        {
            foreach (Student students in _students)
            {
                _students.Remove(students);
                break;
            }

        }

        public void ShowListOfGroup()
        {
            foreach (Group groups in Groups)
            {
                Console.WriteLine(groups);
            }

        }
    }
}
