using library_management.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Data.Interfaces
{
    public interface IAuthorRepository : IRepository<Author>
    {
        IEnumerable<Author> GetAllWithBooks();
        Author GetWithBooks(int id);
    }
}
