using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace LearningCsharp
{
    internal class ArrayListDemo
    {

        ArrayList arrayList = new ArrayList()
        {
            new Customer(){ Name="Raj", Age=22},
            new Customer(){ Name="Ashok", Age=33},
            new Customer(){ Name="Seema", Age=21},
            new Customer(){ Name="Bindra", Age=19},
            new Customer(){ Name="Catheline", Age=20},
        };
       public static void Main()
        {
            new ArrayListDemo();
        }

        public ArrayListDemo()
        {

            foreach (var item in arrayList)
            {
                Console.WriteLine(((Customer)item).Name+"\t"+ ((Customer)item).Age);
            }


        }
    }


    class Customer
    {
        public string Name;
        public int Age;
    }

}
