namespace LMS.Models
{
    public interface ILibraryRepository
    {
        IEnumerable<Book> AllBooks { get; }
        void AddBook(Book book);
        Book? GetBookById(int BookId);
        void UpdateBook(Book book);
        void DeleteBook(int BookId);
    }
}
