namespace SelectionStatementExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            int favNumber = 24;

            do
            {
                Console.WriteLine("Try to guess my favorite number between 1-100!");
                var userInput = int.Parse(Console.ReadLine());

                if (userInput < favNumber)
                {
                    Console.WriteLine("Too low");
                }
                else if (userInput > favNumber)
                {
                    Console.WriteLine("Too high");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                    break;
                }
            } while (true);
        }
    }
}
