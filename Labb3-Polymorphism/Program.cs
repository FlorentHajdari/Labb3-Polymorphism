namespace Labb3_Polymorphism
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Objektreferenser
            Geometry rectangle = new Rectangle();
            Geometry square = new Square ();
            Geometry circle = new Circle ();

            // Lägger in objekten i en lista så att vi kan loopa igenom senare
            Geometry[] figures = new Geometry[] { rectangle, square, circle };

            // Loopar igenom alla objektreferenser och anropar Area() för varje objekt
            foreach (var figure in figures)
            {
                // Skriver ut area resultat för varje objekt
                // F2 rundar cirklens mängd med decimaler till enbart två decimaler, mer läsbart
                Console.WriteLine($"Arean av {figure.GetType().Name} är: {figure.Area():F2} areaenheter ");
            }

            Console.ReadLine();

        }
    }
}
