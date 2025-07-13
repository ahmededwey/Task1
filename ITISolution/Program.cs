
namespace ITISolution
{
    public class Program
    {
        static void Main(string[] args)
        {
             AreaOfSquare(5);
             CheckNumber();
             Student[] students = new Student[]
             {
                 new Student { Id = 1, Name = "Alice", grade = 85 },
                 new Student { Id = 2, Name = "Bob", grade = 90 },
                 new Student { Id = 3, Name = "Charlie", grade = 78 },
                 new Student { Id = 4, Name = "Bob", grade = 90 },
                 new Student { Id = 5, Name = "Charlie", grade = 78 }

             };

             SumOfStudentGrades(students);
            GetNumbersAndSumEvenOdd();
        }



        static public void AreaOfSquare(decimal x)
        {
            Console.WriteLine($"the Area of Square = {x * x}");
        }

        static public void CheckNumber()
        {
            int num;
            while (true)
            {
                Console.Write("Please enter a positive integer: ");
                string input = Console.ReadLine();
                if (int.TryParse(input, out num) && num >= 0)
                    break;
                Console.WriteLine("Invalid input. Please enter a non-negative integer.");
            }

            Console.WriteLine(num % 2 == 0 ? "Even Number" : "Odd Number");
        }

        static public void SumOfStudentGrades(Student[] students)
        {
            decimal sum = 0;
            for (int i = 0; i < students.Length; i++)
            {
                sum += students[i].grade;
            }
            Console.WriteLine($"The sum of student grades is: {sum}");

        }

        static public void GetNumbersAndSumEvenOdd()
        {
            int[] numbers = new int[10];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"Enter number {i + 1}: ");
                while (!int.TryParse(Console.ReadLine(), out numbers[i]))
                {
                    Console.Write("Invalid input. Please enter a valid integer: ");
                }
            }
            EvenNumbersSum(numbers);
        }

        static public void EvenNumbersSum(int[] numbers)
        {

            int Evensum = 0;
            int Oddsum = 0;
            foreach (int number in numbers)
            {
                if (number % 2 == 0)
                {
                    Evensum += number;
                }
                else
                {
                    Oddsum += number;
                }
            }
            Console.WriteLine($"The sum of even numbers is: {Evensum}");
            Console.WriteLine($"The sum of odd numbers is: {Oddsum}");
        }
    }
}
