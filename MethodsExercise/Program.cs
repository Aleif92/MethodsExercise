using System.Reflection.PortableExecutable;

namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
              
            }

            return sum;
        }
        public static int Devide(int numOne, int numTwo)
        {
            return numOne / numTwo;
        }
        public static int Multiply(int numOne, int numTwo)
        {
            return numOne * numTwo;
        }
        public static int subtract(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }
        public static int Add(int num1, int num2)
        {
            return num1 + num2;
            

        }

        public static void Madlib()
        {
            
            Console.WriteLine("What is your name?");

            string userName = Console.ReadLine();
            Console.WriteLine($"Hello, {userName}! What is your favoite Color?");
            string favColor = Console.ReadLine();
            Console.WriteLine("What is your favorite band?");
            string favBand = Console.ReadLine();
            Console.WriteLine("What is your favorite animal?");
            string favAnimal = Console.ReadLine();
            
            Console.WriteLine($" One day, {userName} was driving down the road in a {favColor} SUV. The radio was playing {favBand}!\n {userName} had to slam on the breaks because a {favAnimal} walked out in the middle of the road!\n Thank goodness {userName} and the {favAnimal} were not harmed!");
            

        }
        
        
        static void Main(string[] args)
        {
            
            
          //  Madlib();
          
          //Math Methods

            int added = Add(1, 5);
            Console.WriteLine(added);

            int subtracted = subtract(10, 5);
            Console.WriteLine(subtracted);

            int multiply = Multiply(5, 5);
            Console.WriteLine(multiply);

            int devide = Devide(25, 5);
            Console.WriteLine(devide);

            int result = Sum(5, 5, 5, 5, 55);
            Console.WriteLine(result);

        }
    }
}
