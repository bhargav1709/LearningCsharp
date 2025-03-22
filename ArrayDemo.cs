using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    internal class ArrayDemo
    {
        public static void Main()
        {
            new ArrayDemo();
        }

        public ArrayDemo() 
        {
            /*
             1. Single Dimenion
             2.Multi Dimensional 
             3. Jagged Array
                        
             */

            //int[,] marks = { { 10, 20 },{ 1, 5 },{ 60, 70 } };

            //for (int i = 0; i < marks.GetLength(0); i++)
            //{
            //    for (int j = 0; j < marks.GetLength(1); j++)
            //    {
            //        Console.Write(marks[i,j]+"\t");
            //    }
            //    Console.WriteLine();
            //}

            //int[] x= {10,20,30};
            //int[] y = { 50, 60 };
            //int[] z = { 100, 200, 300, 400 };

            //// Array of an array -> Jagged Array

            //int[][] myarr = new int[3][];
            //myarr[0] = x;
            //myarr[1]=y;
            //myarr[2]=z;

            //for(int i = 0;i<myarr.Length;i++)
            //{
            //    for(int j=0; j < myarr[i].Length;j++)
            //    {
            //        Console.Write(myarr[i][j]+"\t");
            //    }
            //    Console.WriteLine();
            //}

            /*
                    3 Students;
            
                        Phys , Chem, Maths

                    
                    1. Average Marks of Student1
                    
                    

             */
            //Extension Method

            //int[] marks = new int[] { 100, 80, 99, 66, 86, 75, 84, 33, 90, 97, 86, 83, 55, 44, 95 };

            //int totalMarks=marks.Sum();
            //double avgMarks=marks.Average();
            //int minMarks=marks.Min();
            //int maxMarks=marks.Max();

            //Console.WriteLine($"{totalMarks}:{avgMarks}:{minMarks}:{maxMarks}");

            //Array.Sort( marks );
            //Array.Reverse(marks);
            //foreach(int x in marks)
            //{
            //    Console.Write(x + "\t");
            //}
            //Console.WriteLine();


            // double x = 4; int b = 12;
            //  Console.WriteLine(b / c);
            //    a+=  (int)(b /c);
            //   Console.WriteLine(a);
            //  int x = 3 + 4 * 2 / 2 - 4;
            // Console.WriteLine(x);
            ////int x = 10;
            ////int y = 20;

            ////if (x++>10 && y++ <= 20)
            ////    Console.WriteLine($" if X:{x} Y:{y}");
            ////else
            ////    Console.WriteLine($"else X:{x} Y:{y}");
            ///
            //Emp[] employees = 
            //    { 
            //    new Emp() { empName = "Raj", payment = 100 } ,
            //    new Emp() { empName = "Ashok", payment = 500 } ,
            //    new Emp() { empName = "Seema", payment = 300 } 
            //    };

            //// employees[3] = new Emp() { empName = "Mary", payment = 250 };
            ////     double totalPayment = 0;
            //Array.Sort(employees);
            //Console.WriteLine("Name\tPayment");
            //foreach (var item in employees)
            //{
            //    Console.WriteLine(item.empName + "\t" + item.payment);
            //    //totalPayment += item.payment;
            //}
            //Console.WriteLine("Total Payment\t\t" + employees.Sum(x=>x.payment));


             DateTime minDate=DateTime.MinValue;
            DateTime maxDate=DateTime.MaxValue;
            Console.WriteLine($"Min Date::{minDate}");
            Console.WriteLine($"Max Date::{maxDate}");

            // 16, March, Sunday, 2025

            Console.WriteLine($"{DateTime.Today.ToString("dd , MMMM, dddd, yyyy")}");

            Console.Write("Please enter your date of birth(dd/MM/yyyy)::");
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd/MM/yyyy",null);
            TimeSpan ts= DateTime.Today - dob;
            double age = ts.TotalDays / 365.25;
            Console.WriteLine($"Age::{Math.Round(age)}");

            // 3- 4 class 



            ////string[] myarr = { s1, s2 };
            ////Array.Sort(myarr);
            ////foreach (string c in myarr)
            ////{
            ////    Console.WriteLine(c);
            ////}


        }  


        public void CallMe(out int x, out string y)
        {
            x = 20;
            y = "DDD";
        }
    }

    class Emp
    {
        public string empName;
        public double payment;
    }
}
