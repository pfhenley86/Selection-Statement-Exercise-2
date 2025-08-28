namespace SelectionStatementsExercise2
{
    public class Program
    {
        public static void favoriteSubject()
        {
            Console.WriteLine("What is your favorite school subject?");
            string favoriteSubject = Console.ReadLine();

            switch (favoriteSubject.ToLower())
            {
                case "Math":
                    Console.WriteLine("Wow, I really struggled with math in school!");
                    break;
                case "Science":
                    Console.WriteLine("Science was my favorite subject too!");
                    break;
                case "History":
                    Console.WriteLine("We should all love history so we don't repeat it!");
                    break;
                default:
                    Console.WriteLine("Interesting choice! What do you like about it?");
                    break;
            }
        }
        static void Main(string[] args)
        {
           favoriteSubject();
        }
    }
}