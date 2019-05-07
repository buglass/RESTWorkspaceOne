using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WorkspaceOne.Controllers
{
    [Route("api/authors")]
    public class AuthorsController : Controller
    {
        private readonly Services.IRepository _repository;

        public AuthorsController(Services.IRepository repository)
        {
            _repository = repository;
        }

        public IActionResult GetAuthors()
        {
            var authors = _repository.GetAuthors();
            var authorDtos = new List<Models.AuthorDto>();

            foreach(var author in authors)
            {
                authorDtos.Add(
                    new Models.AuthorDto
                    {
                        Name = $"{author.Forename} {author.Surname}",
                        Age = DateTime.UtcNow.Year - author.DateOfBirth.Year
                    });
            }

            return Ok(authorDtos);
        }

        [HttpGet("{id}", Name="GetAuthor")]
        public IActionResult GetAuthor(Guid id)
        {
            var author = _repository.GetAuthor(id);

            if (author == null)
                return NotFound();

            var authorDto = new Models.AuthorDto
            {
                Name = $"{author.Forename} {author.Surname}",
                Age = DateTime.UtcNow.Year - author.DateOfBirth.Year                
            };

            return Ok(authorDto);
        }

        [HttpPost(Name = "CreateAuthor")]
        public IActionResult CreateAuthor([FromBody] Models.AuthorForCreationDto author)
        {
            if (author == null)
                return BadRequest();

            var authorId = Guid.NewGuid();

            var authorEntity = new Entities.Author
            {
                AuthorId = authorId,
                Forename = author.Forename,
                Surname = author.Surname,
                DateOfBirth = author.DateOfBirth
            };

            _repository.AddAuthor(authorEntity);

            return CreatedAtRoute(
                routeName: "GetAuthor",
                routeValues: new { id = authorId },
                value: authorEntity);
        }
    }
}