using System;

namespace WorkspaceOne.Entities
{
    public class Author
    {
        public Guid AuthorId { get; set; }
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}