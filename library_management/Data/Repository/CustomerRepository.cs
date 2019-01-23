using library_management.Data.Interfaces;
using library_management.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace library_management.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(LibraryDbContext context) : base(context)
        {

        }
    }
}
