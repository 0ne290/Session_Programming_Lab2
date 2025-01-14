using System.Text;
using Core;

namespace ConsoleApplication;

internal static class Program
{
    private static async Task Main()
    {
        StreamReader bookFile;
        Console.Write("Enter path to book file: ");
        try
        {
            bookFile = new StreamReader(Console.ReadLine()!, Encoding.UTF8);
        }
        catch (Exception)
        {
            Console.WriteLine("Path to book file is invalid.");
            
            return;
        }
        
        var books = new Books(bookFile);

        Book? book;
        Console.Write("Enter book name: ");
        try
        {
            book = await books.TryGetByName(Console.ReadLine());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);

            return;
        }
        finally
        {
            bookFile.Dispose();
        }
        
        Console.WriteLine($"Book:\n\t{book?.ToString() ?? "does not exists"}.");
    }
}