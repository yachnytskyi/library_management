using library_management.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Data.Interfaces
{
    interface IBookRepository
    {
        IEnumerable<Book> GetAllWithAuthor();
        IEnumerable<Book> FindWithAuthor(Func<Book, bool> predicate);
        IEnumerable<Book> FindWithAuthorAndBorrower(Func<Book, bool> predicate);
    }
}
