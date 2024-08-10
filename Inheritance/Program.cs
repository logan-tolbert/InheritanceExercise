using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Console.WriteLine(" My Pets");
            Console.WriteLine("---------");


            var myBird = new Bird();
            myBird.Movement = "Walk and fly";
            myBird.NumberOfLegs = 2;
            myBird.Diet = "Omnivorus";
            myBird.CanFly = true;
            myBird.Voice = "Kaw Kaw";
            myBird.Color = "Black";
            myBird.BeakOrBill = "Beak";


            Console.WriteLine("My Bird:");
            Console.WriteLine($"Color: {myBird.Color}\n" +
                $"Diet: {myBird.Diet}\n" + $"Can Fly: {myBird.CanFly.ToString()}\n"
                + $"Beak or Bill: {myBird.BeakOrBill}\n" + $"Movement: {myBird.Movement}\n" +
                $"Number of legs: {myBird.NumberOfLegs}");
            Console.WriteLine("My bird is trained quite well if I opened the cage and called him,");
            Console.Write("He would \"");
            myBird.Speak();
            Console.Write("\", ");
            myBird.Fly();
            Console.Write(".\n");
            Console.Write("Knowing how birds are, if he has to use the bathroom " +
                 "he will find a car, do his buisness, and thinks \"");
            
            myBird.PoopOnCar();
            Console.Write("\".");
            Console.WriteLine(Environment.NewLine);

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var mySnake = new Reptile();
            mySnake.Movement = "Slither";
            mySnake.Diet = "Carnivore";
            mySnake.NumberOfLegs = 0;
            mySnake.Voice = "Hisssss";
            mySnake.Color = "black and brown";
            mySnake.CanChangeColor = false;
            mySnake.LaysEggs = true;
            

            Console.WriteLine("My Snake:");
            Console.WriteLine($"Color: {mySnake.Color}\n" +
                $"Diet: {mySnake.Diet}\n" + $"Lays eggs: {mySnake.LaysEggs.ToString()}\n" 
                 + $"Changes color: {mySnake.CanChangeColor.ToString()}\n" + $"Movement: {mySnake.Movement}\n" +
                 $"Number of legs: {mySnake.NumberOfLegs}\n"); 
            Console.WriteLine("My snake doesnt do much. It is fun to watch him slither around though.");
            Console.Write("Some times when I open the cage to feed him, he says \"");
            mySnake.Speak();
            Console.Write("\"\nWhen he sheds his skin, he probably thinks to himself \"");
            mySnake.ShedSkin();
            Console.Write("\".");
            Console.WriteLine(Environment.NewLine);



        }
    }
}
