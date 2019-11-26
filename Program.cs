using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dog
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog myDog = new Dog();
            myDog.Name = "Fido";
           
            
            
            
            
            Dog doTrick = new Dog();
            myDog.trickName("Fetch");
            // To do: uncomment the following lines of code to call the methods
             //myDog.bark();
            // myDog.doTrick("Fetch");
            Console.WriteLine("{0} is Barking...", myDog.Name);

            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", myDog, trickName);



        }
    }
}
