using System;
using System.Collections.Generic;
namespace _4.Students
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studentList = new List<Student>();
            string input = Console.ReadLine();
            while (input != "end")
            {
                string[] command = input.Split(" ");
                Student students = new Student(command[0], command[1], int.Parse(command[2]), command[3]);
                studentList.Add(students);
                input = Console.ReadLine();
            }
            string cityName = Console.ReadLine();
            foreach (Student student in studentList)
            {
                if (cityName == student.HomeTown)
                {
                    Console.WriteLine($"{student.FirstName} {student.LastName} is {student.Age} years old.");
                }
            }
        }
    }
    class Student
    {
        public Student(string firstName, string lastName, int age, string homeTown)
        {
            this.FirstName = firstName;
            LastName = lastName;
            Age = age;
            HomeTown = homeTown;
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string HomeTown { get; set; }
    }
}
