// Declares a public class
public class Book
{
    
// Properites 
    public string Title { get; set; }
    public string Author { get; set; }
    public string ISBN { get; set; }

// Constructor
    public Book(string title, string author, string isbn)
    {
        Title = title;
        Author = author;
        ISBN = isbn;
    }

// ToString() Method Override
    public override string ToString()
    {
        return $"{Title} by {Author} (ISBN: {ISBN})";
    }
}
