using API.DTO;
using Application.Commands;
using Application.Commands.BlogPosts;
using Application.Queries;
using AutoMapper;
using Domain.Models;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public CategoriesController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        // GET: api/<CategoriesController>
        [HttpGet]
        public async Task<IActionResult> GetCategories(CancellationToken cancellationToken)
        {
            var query = new GetCategoriesQuery();
            var response = await _mediator.Send(query, cancellationToken);
            var categories = _mapper.Map<List<CategoryGetDto>>(response.Payload);

            return Ok(categories);
        }

        // GET api/<CategoriesController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetCategoriesById(int id, CancellationToken cancellationToken)
        {
            var query = new GetCategoriesByIdQuery
            {
                CategoryId = id
            };

            var response = await _mediator.Send(query, cancellationToken);

            var category = _mapper.Map<CategoryGetDto>(response.Payload);

            return Ok(category);
        }

        // POST api/<CategoriesController>
        [HttpPost]
        public async Task<IActionResult> CreateCategory([FromBody] CategoryPutPostDto category, CancellationToken cancellationToken)//UserCreateUpdate user)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var command = _mapper.Map<CreateCategoryCommand>(category);
            var response = await _mediator.Send(command, cancellationToken);
            var dto = _mapper.Map<CategoryGetDto>(response.Payload);

            return
                CreatedAtAction(nameof(GetCategoriesByIdQuery), new { id = response.Payload.CategoryId }, dto);
        }

        // PUT api/<CategoriesController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCategory(int id, CategoryPutPostDto updatedCategory, CancellationToken cancellationToken)
        {
            var command = _mapper.Map<UpdateCategoryCommand>(updatedCategory);
            command.CategoryId = id;
            var response = await _mediator.Send(command, cancellationToken);

            if (response == null)
                return NotFound();

            return NoContent();                     //?
        }

        // DELETE api/<CategoriesController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCategory(int id, CancellationToken cancellationToken)
        {
            var command = new DeleteCategoryCommand() { CategoryId = id };
            var response = await _mediator.Send(command, cancellationToken);

            if (response == null)
                return NotFound();

            return NoContent();
        }
    }
}
