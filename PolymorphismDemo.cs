using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LearningCsharp
{
    internal class PolymorphismDemo
    {
        public static void  Main()
        {
            new PolymorphismDemo();
        }

        public PolymorphismDemo()
        {
            //Animal an = null;
            //string ans = "y";
            //do
            //{
            //    Console.WriteLine("1.Dog");
            //    Console.WriteLine("2.Cat");
            //    Console.WriteLine("3.Bird");
            //    Console.Write("Please enter your choice::");
            //    int ch = int.Parse(Console.ReadLine());
            //    switch (ch)
            //    {
            //        case 1:
            //            an = new Dog();
            //            break;
            //        case 2:
            //            an = new Cat();
            //            break;
            //        case 3:
            //            an = new Bird();
            //            break;
            //    }
            //    Show(an);
            //    Console.Write("do u wanna continue(y/n)?");
            //    ans = Console.ReadLine();
            //} while (ans == "y");

            ILandAnimal animal = new Bird();
            Show(animal);

            //Dog class implements ILandAnimal -> IAnimal  IAnimal or ILandAnimal

            //Cat class implements ILandAnimal -> IAnimal  IAnimal or ILandAnimal

            //Bird class implements ILandAnimal, IFlyingAnimal -> IAnimal  IAnimal or ILandAnimal

            // IFlyingAnimal flyingAnimal = new Bird();
            


        }



        public void Show(IAnimal an)
        {
            Console.WriteLine("Name::" + an.Name());
            Console.WriteLine("Voice::" + an.Voice());
            Console.WriteLine("Shelter::" + an.Shelter());
            Console.WriteLine("Food::" + an.Food());
            if (an is ILandAnimal)
            {
                Console.WriteLine("No of Legs::" + ((ILandAnimal)an).NoOfLegs());
                Console.WriteLine("Running Speed::" + ((ILandAnimal)an).RunningSpeed());

            }
            if (an is IFlyingAnimal)
            {
                Console.WriteLine("No of Wings::" + ((IFlyingAnimal)an).NoOfWings());
                Console.WriteLine("Flying Speed::" + ((IFlyingAnimal)an).FlyingSpeed());

            }

        }

    }

    // An abstract class is class that cannot be instantiated
    // So the only purpose of abstract class in inheritance and polymoorphsm
    interface IAnimal
    {
        //An abstract method is a method which do not have any body
        string Name();

         string Voice();

        string Shelter();

        string Food();
        
    }

    interface ILandAnimal:IAnimal
    {
         string NoOfLegs();
        string RunningSpeed();

    }

     interface IFlyingAnimal:IAnimal
    {
        string NoOfWings();
       string FlyingSpeed();
    }
        
    class Dog : ILandAnimal
    {
        public  string Name()
        {
            return "Dog";
        }
        public  string Voice()
        {
            return "Bark";
        }
        public string Shelter()
        {
            return "Kennel";
        }
        public  string Food()
        {
            return "Bone";
        }

        public string NoOfLegs()
        {
            return "4";
        }

        public string RunningSpeed()
        {
            return "60km/hr";
        }

       
    }
    class Cat:ILandAnimal
    {
        public string Name()
        {
            return "Cat";
        }
        public string Voice()
        {
            return "Meow";
        }
        public  string Shelter()
        {
            return "Home";
        }
        public string Food()
        {
            return "Fish";
        }

        public string NoOfLegs()
        {
            return "4";
        }

        public  string RunningSpeed()
        {
            return "70 km/hr";
        }
    }
    class Bird : ILandAnimal, IFlyingAnimal
    {
        public  string Name()
        {
            return "Bird";
        }
        public  string Voice()
        {
            return "chirp";
        }

        public  string Shelter()
        {
            return "Nest";
        }
        public  string Food()
        {
            return "worms";
        }

        public string NoOfLegs()
        {
            return "2";
        }

        public string RunningSpeed()
        {
            return "20 km/hr";
        }

        public string NoOfWings()
        {
            return "2";
        }

        public string FlyingSpeed()
        {
            return "65 km/hr";
        }
    }


    //class Customer
    //{
    //    public string CustomerName { get; set; }
        

    //    // Has a relationship

    //    public Address Address { get; set; }


    //}

    //class Address
    //{
    //    public string StreetNo { get; set; }
    //    public string StreetName { get; set; }

    //    public string City { get; set; }

    //    public string State { get; set; }

    //    public string Country { get; set; }

    //    public string PinCode { get; set; }


    //}


     
    }


   

