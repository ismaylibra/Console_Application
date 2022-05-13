using Course_Managment_Application.Enums;
using System;

namespace Course_Managment_Application
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(Enum.GetNames(typeof(Category)));
        }
    }
}
