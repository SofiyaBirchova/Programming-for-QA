namespace _03.OldBooks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string favoriteBook = Console.ReadLine();
            
            string current = Console.ReadLine();
            int checkedBooks = 0;

            while (current != "No More Books" && current != favoriteBook)
            {
                checkedBooks++;
                current = Console.ReadLine();
            }
            if (current == favoriteBook)
            {
                Console.WriteLine($"You checked {checkedBooks} books and found it.");
            }
            else
            {
                Console.WriteLine("The book you search is not here!");
                Console.WriteLine($"You checked {checkedBooks} books.");
            }
        }
    }
}