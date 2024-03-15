using LMS.Models;

namespace LMS.ViewModel
{
    public class LibraryListViewModel
    {
        public IEnumerable<Book> Books { get; }

        public LibraryListViewModel(IEnumerable<Book> books)
        {

            Books = books;
        }
    }
}
