using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryExample
{
    class BookRepository
    {
        public void Add(Book book)
        {
            Storage.DoOwnWork();
        }

        public void Delete(Book book)
        {
            Storage.DoOwnWork();
        }

        public void Update(Book book)
        {
            Storage.DoOwnWork();
        }

        public IList<Book> GetAll()
        {
            Storage.DoOwnWork();
            return new List<Book>();
        }

        public Book GetBook(Guid id)
        {
            Storage.DoOwnWork();
            return new Book();
        }

    }
}
