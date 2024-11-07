namespace Labb3_Polymorphism
{
    public class Rectangle : Geometry // Child class som ärver från Geometry
    {
        // Egenskaper
        public double Length { get; set; }
        public double Width { get; set; }

        public Rectangle() // Konstruktor med värden
        {
            Length = 9;
            Width = 4;
        }

        public override double Area() // override som beräknar area för rektangel
        {  
          return Length * Width; // faktorer som ska slås ihop
        }

    }

    public class Square : Geometry // Child class som ärver från Geometry
    {
        // Egenskaper
        public double Side { get; set; }

        public Square() // Konstruktor med värde
        {
            Side = 5;
        }

        public override double Area() // Override som beräknar area för kvadrat
        {
            return Side * Side; // faktorer som ska slås ihop
        }
    }
    public class Circle : Geometry // Child class som ärver från Geometry
    {
        // Egenskaper

        public double Radius { get; set; }

        public Circle() // Konstruktor med radie värde
        {
            Radius = 3;
        }

        public override double Area() // Override som räknar area för cirkel
        {
            return Math.PI * Radius * Radius; // formel för hur arean ska fram
        }
    }
}
