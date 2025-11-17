using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes
            
            /* Create an object of your Bird class, give values to
             * your members using the object of your Bird class.
             *
             * Creatively display the class member values
             */
            var myBird = new Bird();
            myBird.AnimalName = "Golden Eagle";
            myBird.WingLength = 8; // up to 8 feet
            myBird.Diet = DietType.Carnivore;
            myBird.Habitat = "Air near mountains and canyons";
            myBird.IsApex = true;
            myBird.CanFly = true;
            myBird.WillMigrate = true;
            
            /* Create an object of your Reptile class, give values to
             * your members using the object of your Reptile class
             *
             * Creatively display the class member values
             */
            var myReptile = new Reptile();
            myReptile.AnimalName = "Crocodile";
            myReptile.Diet = DietType.Carnivore;
            myReptile.IsColdBlooded = true;
            myReptile.IsScaly = true;
            myReptile.IsApex = true;
            myReptile.Habitat = "Water";
            myReptile.CanGrowTail = true;

            /* Create animal objects and store the two animals
             * we created in them. And display some of the fields.
             */
            var myAnimals = new Animal[] { myBird, myReptile };

            foreach (var animal in myAnimals)
            {
                Console.WriteLine($"\nAnimal Type: {animal.AnimalName}");
                Console.WriteLine($"Diet Type:   {animal.Diet}");
                Console.WriteLine($"Is Apex Predator: {animal.IsApex}");
                Console.WriteLine($"It lives by {animal.Habitat}");
            }
            
            

            
        }
    }
}
