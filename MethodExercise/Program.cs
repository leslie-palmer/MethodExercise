using System;

namespace MethodExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Instantiates and initializes four strings with user input
            //Name
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            //Favorite Color
            Console.WriteLine("What is your favorite color?");
            string color = Console.ReadLine();
            //Favorite Animal
            Console.WriteLine("What is your favorite animal?");
            string animal = Console.ReadLine();
            //Favorite Band
            Console.WriteLine("What is your favorite band?");
            string band = Console.ReadLine();

            //Assemble input into story and recite
            Console.WriteLine($"You are the Warrior of Legend, {name}.\n" +
                $"You are about to embark on the Quest of Prophecy with your Familiar, a {color} {animal} who will aid you in your Quest.\n" +
                $"Your journey will be accompanied by an original soundtrack from {band}.");
            
            //Passes arguments to the math operator methods and recites the result
            int add = Sum(1, 2, 3, 4);
            Console.WriteLine($"\nThe sum of the provided numbers is {add}");
            int sub = Diff(5, 4);
            Console.WriteLine($"The difference between the provided numbers is {sub}");
            int mult = Prod(3, 6);
            Console.WriteLine($"The product of the provided numbers is {mult}");
            int div = Quo(15, 3);
            Console.WriteLine($"The quotient of the provided numbers is {div}");
            int mod = Rem(5, 2);
            Console.WriteLine($"The remainder of the provided dividends is {mod}");
            Console.WriteLine("Try putting your own numbers in and see how they work.");



        }
        
        //Sum (addition) method
        //Takes any number of int agruments and places them in an int array
        //All array elements are added together through a for loop
        public static int Sum(params int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum = sum + nums[i];
            }
            return sum;
        }

        //Difference (subtraction) method
        public static int Diff(int x, int y)
        {
            return x - y;
        }

        //Product (multiplication) method
        public static int Prod(int x, int y)
        {
            return x * y;
        }

        //Quotient (division) method
        public static int Quo(int x, int y)
        {
            return x / y;
        }

        //Remainder (modulus) method
        public static int Rem(int x, int y)
            => x % y;
    }
}
