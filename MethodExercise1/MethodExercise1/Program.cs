using System;

namespace MethodExercise1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            var yourName = Console.ReadLine();

            Console.WriteLine($"Hello, {yourName}! Let's plan your dream day.");

            Console.WriteLine("Are you sleeping in or waking up early?");
            var dayTime = Console.ReadLine();

            Console.WriteLine("What is your favorite color?");
            var favColor = Console.ReadLine();

            Console.WriteLine("What is your favorite exotic animal?");
            var favAnimal = Console.ReadLine();

            Console.WriteLine("What is the name of your favorite City?");
            var favPlace = Console.ReadLine();

            Console.WriteLine("What is your favorite food?");
            var favFood = Console.ReadLine();

            Console.WriteLine($"Your dream day would start off by {dayTime}. " +
                              $"You would put on your favorite {favColor} shirt," +
                              $"grab your pet {favAnimal}, and head to {favPlace} for a walk around town." +
                              $"You would them head to a local restraunt for some {favFood}." +
                              $"After eating all that {favFood} though, you would have to head home to take a nap." +
                              $"A day well spent.");

            Console.WriteLine(Add(2, 4));
            Console.WriteLine(Add(4, 7));

            Console.WriteLine(Multiply(3, 5));
            Console.WriteLine(Multiply(4, 6));

        }
        public static int Add(int optionOne, int optionTwo)
        {
            var answer = optionOne + optionTwo;
            return answer;
        }


        public static int Multiply(int first, int second)
        {
            var answer = first * second;
            return answer;

        }
    }
}
