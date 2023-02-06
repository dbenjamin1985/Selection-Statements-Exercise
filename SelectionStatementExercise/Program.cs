namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main()
        {
            var r = new Random();
            var favNumber = r.Next(1, 10);
            Console.WriteLine("Guess the random number! It's 1 through 10!");
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < favNumber)
                Console.WriteLine("Too low playa!");
            else if (userInput > favNumber)
                Console.WriteLine("Too high playa!");
            else
                Console.WriteLine("You right on the money dawg!!");
        }
    }
}
