using System;
using System.Collections.Generic;

namespace WorkspaceOne.Services
{
    public interface IRepository
    {
        IEnumerable<Entities.Author> GetAuthors();
        Entities.Author GetAuthor(Guid authorId);
        void AddAuthor(Entities.Author author);
        void UpdateAuthor(Entities.Author author);
        void DeleteAuthor(Entities.Author author);
        IEnumerable<Entities.Author> GetBooksForAuthor(Guid authorId);
        IEnumerable<Entities.Author> GetBookForAuthor(Guid authorId, Guid bookId);
        void AddBookForAuthor(Guid authorId, Entities.Book book);
        void UpdateBookForAuthor(Guid authorId, Entities.Book book);
        void DeleteBookForAuthor(Guid authorId, Entities.Book book);
    }
}