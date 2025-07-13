namespace D05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region BookClassExample
            Book book1 = new Book();
            Book book2 = new Book();
            book1.GetDataFromUser();
            book2.GetDataFromUser();
            Console.WriteLine(book1);
            Console.WriteLine(book2);
            #endregion
            #region VisstorClassExample
            Visitor visitor1 = new Visitor();
            Visitor visitor2 = new Visitor();
            visitor1.GetDataFromUser();
            visitor2.GetDataFromUser();
            Console.WriteLine(visitor1);
            Console.WriteLine(visitor2);


            #endregion
            #region CircleClassExample
            Circle circle1 = new Circle();
            Circle circle2 = new Circle(5.0); // Example with radius 5.0
            Circle circle3 = new Circle(circle2); // Copy constructor
            Console.WriteLine(circle1);
            Console.WriteLine(circle2);
            Console.WriteLine(circle3);

            #endregion
            #region TimeExample
            Time time1 = new Time(5, 57, 07);
            Time time2 = new Time(7,55,44);
           Time time3= time1.AddingTwoTimes(time2);
            Console.WriteLine( time3);


            #endregion


            #region WeatherExample
            weather();
            #endregion


        }
        static void weather()
        {

            Console.WriteLine("Enter a season (Spring, Summer, Autumn, Winter): ");
            int input = int.Parse(Console.ReadLine());

                switch (input)
                {
                    case 1:
                        Console.WriteLine("Spring: March to May");
                        break;
                    case 2:
                        Console.WriteLine("Summer: June to August");
                        break;
                    case 3:
                        Console.WriteLine("Autumn: September to November");
                        break;
                    case 4:
                        Console.WriteLine("Winter: December to February");
                        break;
                     default:
                        Console.WriteLine("Invalid season. Please enter a number between 1 and 4.");
                        break;
            }

          
            
        }




    }

   
}
