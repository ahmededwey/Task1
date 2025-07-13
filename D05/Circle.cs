namespace D05
{
    //     class Circle
    public class Circle
    {
        public double Radius { get; set; }
        public double Area { get; set; }
        public double Circumference { get; set; }
        // Default Constructor
        public Circle()
        {
            Radius = 0;
            Area = 0;
            Circumference = 0;
        }
        // Parameterized Constructor
        public Circle(double radius)
        {
            Radius = radius;
            Area = Math.PI * radius * radius;
            Circumference = 2 * Math.PI * radius;
        }
        // Copy Constructor
        public Circle(Circle circle)
        {
            Radius = circle.Radius;
            Area = circle.Area;
            Circumference = circle.Circumference;
        }
        public void GetDataFromUser()
        {
            Console.WriteLine("Enter Circle Radius: ");
            Radius = double.Parse(Console.ReadLine());
            Area = Math.PI * Radius * Radius;
            Circumference = 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"Radius: {Radius}, Area: {Area}, Circumference: {Circumference}";
        }
    }
}
