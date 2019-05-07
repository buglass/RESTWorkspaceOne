using System;
using System.Collections.Generic;
using WorkspaceOne.Entities;

namespace WorkspaceOne.Services
{
    public class Repository : IRepository
    {
        public IEnumerable<Entities.Author> GetAuthors()
        {
            throw new NotImplementedException();
        }
        void IRepository.AddAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        void IRepository.AddBookForAuthor(Guid authorId, Book book)
        {
            throw new NotImplementedException();
        }

        void IRepository.DeleteAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        void IRepository.DeleteBookForAuthor(Guid authorId, Book book)
        {
            throw new NotImplementedException();
        }

        Author IRepository.GetAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Author> IRepository.GetBookForAuthor(Guid authorId, Guid bookId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<Author> IRepository.GetBooksForAuthor(Guid authorId)
        {
            throw new NotImplementedException();
        }

        void IRepository.UpdateAuthor(Author author)
        {
            throw new NotImplementedException();
        }

        public void IRepository.UpdateBookForAuthor(Guid authorId, Book book)
        {
            throw new NotImplementedException();
        }
    }
}