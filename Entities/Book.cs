using System;

namespace WorkspaceOne.Entities
{
    public class Book
    {
        public Guid BookId { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime DateOfPublication { get; set; }
    }
}