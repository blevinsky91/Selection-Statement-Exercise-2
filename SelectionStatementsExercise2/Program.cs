namespace SelectionStatementsExercise2
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");
            Console.WriteLine("What is your favorite school subject?");
            var subject = Console.ReadLine();


            switch (subject.ToLower())
            {
                case "math":
                    Console.WriteLine("Not quite");
                    break;
                case "history":
                    Console.WriteLine("Not bad, but no");
                    break;
                case "english":
                    Console.WriteLine("No chance!");
                    break;
                case "spanish":
                    Console.WriteLine("No bueno!");
                    break;
                case "science":
                    Console.WriteLine("You know it!");
                    break;
                default:
                    Console.WriteLine("Keep guessing!");
                    break;
            }
        }
    }
}