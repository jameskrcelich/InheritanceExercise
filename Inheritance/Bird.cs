namespace Inheritance;

// Create a class Bird
// give this class 4 members that are specific to Bird
// Set this class to inherit from your Animal Class
public class Bird : Animal
{
    public Bird()
    {
        IsAlive = true;
        Legs    = 2;
        Age     = 0;
        BeakLength = 3.5;
    }
    
    public float WingLength {get; set;}
    public bool CanFly {get; set;}
    public bool WillMigrate { get; set;}
    public double BeakLength {get; set;}
}