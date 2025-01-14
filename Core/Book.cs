namespace Core;

public class Book
{
    public Book(string text)
    {
        var bookData = text.Split(",");

        if (bookData.Length != 3)
            throw new Exception($"Text is invalid. Text: {text}.");

        AuthorSurname = bookData[0].Trim();
        Name = bookData[1].Trim();
        PublicationYear = int.Parse(bookData[2].Trim());
    }

    public override string ToString() =>
        $"author surname: {AuthorSurname}, name: {Name}, publication year: {PublicationYear}";

    public string AuthorSurname { get; }
    
    public string Name { get; }
    
    public int PublicationYear { get; }
}