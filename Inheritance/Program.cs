using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // DONE TODO Be sure to follow best practice when creating your classes

            // DONE Create a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class



            var myBird = new Bird();
            myBird.FeatherColor = "blue";
            myBird.CanFly = true;
            myBird.DoMigrate = true;
            myBird.IsAlive = true;




            var myReptile = new Reptile()
            {
                IsColdBlooded = true,
                MakesNoise = true,
                IsScaley = true,
                Habitat = "swamp"
            };

            var myAnimals = new Animal[] { myBird, myReptile };

            foreach(var animal in myAnimals)
            {
                Console.WriteLine($"Alive:{animal.IsAlive}");
                Console.WriteLine($"Age:{animal.Age} years old");
                Console.WriteLine($"It has {animal.LegCount} legs");
                Console.WriteLine($"It lives by {animal.LandSeaAir}");
            }

            

            /*DONE Create an object of your Bird class
             *DONE  give values to your members using the object of your Bird class
             *  
             * DONECreatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
