using System;

namespace WorkspaceOne.Models
{
    public class AuthorForCreationDto
    {
        public string Forename { get; set; }
        public string Surname { get; set; }
        public DateTime DateOfBirth { get; set; }        
    }
}