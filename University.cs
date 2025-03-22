using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LearningCsharp
{
    internal class University
    {

        public static void Main()
        {
            new University();
        }

        public List<Student> students = new List<Student>();
        


        public University()
        {



            Student student = new Student() { Name = "AAA" };
            Student cstudent = new CStudent("DDD", "L1");
            Student rstudent = new RStudent("EEE", "H1", "R1");

            students.Add(student);
            students.Add(cstudent);
            students.Add(rstudent);

            foreach (Student s in students)
            {
                DisplayStudent(s);
            }


        }

        public void DisplayStudent(Student student)
        {
            Console.Write($"ID:{student.Id}\t Name::{student.Name}");
            if(student is CStudent)
            {
                Console.Write($"\t LockerNo :: {((CStudent)student).LockerNo}");

            }
            if (student is RStudent)
            {
                Console.Write($"\t Hostel No::{((RStudent)student).HostelNo} \t RoomNo:: {((RStudent)student).RoomNo}");

            }
            Console.WriteLine($"\tFees::{student.Fees()}");
        }

    }

    class Student
    {

        private static int _id;

        public Student()
        {
            _id++;
            Id = _id;
        }

        public Student(string name):this()
        {
            Name = name;
        }
        public int Id { get; }
        public string Name { get; set; }


        public virtual double Fees()
        {
            return 100;
        }
        
    }

    class CStudent:Student
    {
       
        public CStudent(string name, string lockerNo):base(name)
        {
            
            LockerNo = lockerNo;
        }
        public string LockerNo { get; set; }

        public override double Fees()
        {
            return 120;
        }
    }

    class RStudent:Student
    {
        public RStudent(string name, string hostelNo, string roomNo) : base(name)
        {
            HostelNo = hostelNo;
            RoomNo = roomNo;
            
        }
        public string HostelNo { get; set; }
        public string RoomNo { get; set; }
        public override double Fees()
        {
            return 150;
        }
    }

}
