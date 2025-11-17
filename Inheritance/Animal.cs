namespace Inheritance;

// Create a class Animal
// give this class 4 members that all Animals have in common
public enum DietType
{
    Herbivore,
    Carnivore,
    Omnivore,
    Insectivores,
    Frugivores,
    Folivores,
    Piscivores,
    Bacterivores,
}

public class Animal
{
    public Animal( ) {}
    
    public DietType Diet { get; set; }
    
    public string AnimalName { get; set; }

    public bool IsApex { get; set; }
    public bool IsAlive { get; set; }
    
    public int Legs {get; set;}
    public int Age {get; set;}
    public string Habitat { get; set; }
}