namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main()
        {
            var r = new Random();
            var favNumber = r.Next(85);
            var userInput = int.Parse(Console.ReadLine());
            if (userInput < 85)
                Console.WriteLine("Too low playa!");
            else if (userInput > 85)
                Console.WriteLine("Too high playa!");
            else
                Console.WriteLine("You right on the money dawg!!");
        }
    }
}
