namespace Core;

public class Books
{
    public Books(StreamReader streamReader)
    {
        _streamReader = streamReader;
    }

    public async Task<Book?> TryGetByName(string? name)
    {
        if (name == null)
            return null;
        
        while (await _streamReader.ReadLineAsync() is { } line)
        {
            var book = new Book(line);

            if (book.Name == name)
                return book;
        }

        return null;
    }

    private readonly StreamReader _streamReader;
}