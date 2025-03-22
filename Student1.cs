using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    internal class Student1
    {


        //
        public static Student1 singletonObject = null;
        private static int objectCount;
        static Student1()
        {
           
            id = 100;
        }
        
        private Student1()
        {
           
            id++;
            StudentID = id;
            objectCount++;

        }


        public static Student1 CreateStudent(string Name, string Email, int Age)
        {
            if (singletonObject == null)
            {
                singletonObject = new Student1(Name,Email,Age);
            }
            return singletonObject;


        }

       
        public static int getObjectCount()
        {
            return objectCount;
        }
        private Student1(string Name, string Email, int Age):this()
        {
            
            this.Name = Name;
            this.Email = Email;
            this.Age = Age;
            
        }

        private static int id;
        public int StudentID { get; }
        private string name;
        public string Name 
        {
            get { return name; }
            set
            {
                if (value.Length >= 3)
                    name = value;
                else
                    name="-1";
            }
        }

        public string Email { get; set; }
       
        private int age;


        public int Age 
        { 
            get
            {  return age; }
                
            set
            {
                if (value > 0 && value < 100)
                    age = value;
                else
                    age = -1;
            }
                
        }

        ////Mutator
        ////Setter
        //public void SetAge(int age)
        //{
        //    if (age > 0 && age < 100)
        //        Age = age;
        //    else
        //         Age = -1;
        //}

        ////Accessor
        ////Getter
        //public int GetAge()
        //{
        //    return Age;
        //}

       
    }

  
}
