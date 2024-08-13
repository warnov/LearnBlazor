using Bookstore.Models;

namespace Bookstore.Services
{
    public interface IBooksService
    {
        Task<List<Book>> GetAllBooksAsync();
    }
}
