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
                case "Math":
                    Console.WriteLine("Not quite");
                    break;
                case "History":
                    Console.WriteLine("Not bad, but no");
                    break;
                case "English":
                    Console.WriteLine("No chance!");
                    break;
                case "Spanish":
                    Console.WriteLine("No bueno!");
                    break;
                case "Science":
                    Console.WriteLine("You know it!");
                    break;
                default:
                    Console.WriteLine("Keep guessing!");
                    break;
            }
        }
    }
}