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
            myDog.bark = "Woof";
            myDog.doTrick = "Fetch";
             
           
            
            
            
            
            Dog doTrick = new Dog();
           // myDog.trickName("Fetch");
            // To do: uncomment the following lines of code to call the methods
            // myDog.bark();
            // myDog.doTrick("Fetch");
            Console.WriteLine("{0} is Barking...", myDog.Name);

            Console.WriteLine("{0} is so smart!  {0} is doing a(n) {1}", myDog.Name, myDog.doTrick);


            /*
             *
1.	Identify and describe the following elements of the method header given the following method called getArea().  
You must identify where they are in the method header example, other possible values and what the significance of each is (what does it mean?) (12 points – 2 points each)



a.	Scope  
(Double height, double width)  The scope is when the variable is declared.  As these are numerical values, int could have also been used.  
The scope of this method defines what will be used in other parts of the method.

b.	Static vs. Non-Static
	This method is non-static.  After the public declaration, it would have been declared a static method using the static     	type.  An alterative would be to make this method private.

c.	Return Type
		double This is a numerical value. One which can hold a decimal value.  An int may have been used instead, depending on what the creator wants.

d.	Method Name (Identifier)
	getArea.  This names the method.  It is named so that the programers could easily identify what this method would     	likely be used for.

e.	Parameters
height,  width. These parameters are what the method will use to carry out its function.  They may be defined by either input from a user or declared in the body of the program

f.	Method Body
	return height * weight This is what this method will carry out when executed.


1.	Explain the difference between a user-defined method and a method that is provided with a framework.  What should we consider when creating a user-defined method? (3 points)
A user defined method is one created by the user.  The programer needs to set up the entire method, and set its parameters.  While this lets the programer define the method to his specific needs and specifications, it can also lead to mistakes.  If a simal framework exists, it is can be a time saver to use a pre-made one instead.  A method that is provided by the framework might not fit the needs of the app in its current form, but it might fit others, or be modified in order to fit.  This can save time, reuse code that is proven to work and maybe be more efficient.

2.	Discuss the difference between a static and non-static method (2 points)
The difference between static and non-static methods is how they relate to a class.  Static methods related to the entire class.  Non static methods related more to objects in a class.  They need a class to be created for them to work properly, as they will be referencing an object in that class.  . A static method does not need this.
             * 
             */




        }
    }
}
