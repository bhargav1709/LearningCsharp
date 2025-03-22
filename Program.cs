using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace LearningCsharp
{
    internal class Program
    {
        
        
        static void Main(string[] args)
        {

           ////Student s1 = Student.CreateStudent("Raj", "r@j.com", 22);
           // DisplayStudent(s1);
           // Console.WriteLine($"Object Created::{Student.getObjectCount()}");
           // //Student s2 = Student.CreateStudent("Ashok", "a@j.com", 22);
           // DisplayStudent(s2);
           // Console.WriteLine($"Object Created::{Student.getObjectCount()}");
           //// Student s3 = Student.CreateStudent("Seema", "s@j.com", 22);
           // DisplayStudent(s3);
           // Console.WriteLine($"Object Created::{Student.getObjectCount()}");

        }

        //static void DisplayStudent(Student student)
        //{
        //    if (student.Age == -1)
        //        Console.WriteLine("Age is error!!Kindly re-enter your data");
        //    else if(student.Name=="-1")
        //        Console.WriteLine("Name is error!!Kindly re-enter your data");
        //    else
        //    {
        //        Console.WriteLine(student.StudentID+"\t"+student.Name + "\t" + student.Email + "\t" + student.Age);
        //    }
        //}


        public static int Calc(int x, int y, ref string oper)
        {
            int result = 0;
            switch (oper)
            {
                case "+":
                    result = x + y;
                    break;
                case "-":
                    result = x - y;
                    break;
                case "*":
                    result = x * y;
                    break;
                case "/":
                    result = x / y;
                    break;
            }
            oper = x + oper + y;
            return result;
        }
        public static void Swap(int x,int y )
        {
            Console.WriteLine($"In Swap before swapping... X::{x},Y::{y}" );
            int temp = x;
            x = y;
            y = temp;
            Console.WriteLine($"In Swap after swapping... X::{x},Y::{y}");

        }
       

        public static int Add( string y, params int[] x)
        {
            int sum = 0;
            foreach (int i in x)
            {
                sum += i;
            }
            return sum;
        }

      

        public static void CallMe(object x)
        {
            if (x is double)
            {
                Console.WriteLine((double)x + (double)x);
            }
        }
    }

   
    class A
    {
        public static int x;
        public int y;



    }
}
