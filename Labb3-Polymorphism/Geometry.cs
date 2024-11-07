namespace Labb3_Polymorphism
{
    public class Geometry // Parent class
    {
        // virtuell metod för att beräkna area, ska kunna overridas då alla har egna formler
        public virtual double Area() 
        {
            return 0; // Standardvärde om metoden ej overrideas
        }
    }
}
