using API.DTO;
using Application.Commands.Users;
using Application.Queries;
using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly IMapper _mapper;

        public UserController(IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }


        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> GetUsers()
        {
            var query = new GetUsersQuery();
            var response = await _mediator.Send(query);
            var users = _mapper.Map<List<UsersGetDto>>(response.Payload);

            return Ok(users);
        }

        // GET api/<UserController>/5
        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var query = new GetUserByIdQuery
            {
                UserId = id
            };

            var response = await _mediator.Send(query);
            var user = _mapper.Map<UsersGetDto>(response.Payload);

            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserPostDto user)

        {

            var command = _mapper.Map<CreateUserCommand>(user);
            var response = await _mediator.Send(command);

            var dto = _mapper.Map<UsersGetDto>(response.Payload);

            return
                CreatedAtAction(nameof(GetUserById), new { id = response.Payload.UserId }, dto); 
        }
    


        /*
        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> CreateUser([FromBody] UserPutPostDto user, CancellationToken cancellationToken)//UserCreateUpdate user)
        {
           

            var command = new CreateUserCommand()
            {
                
                FirstName = user.FirstName,
                LastName = user.LastName,
                Gender = user.Gender,
                DOB = user.DOB,
                EmailAddress = user.EmailAddress,
                
            };
           
            var command=_mapper.Map<CreateUserCommand>(user);
            var response=await _mediator.Send(command, cancellationToken);
            
            var dto = _mapper.Map<UsersGetDto>(response);

            return response.IsError ? HandleAPIError(response.Errors) :
                CreatedAtAction(nameof(GetUserById), new { userId = dto.UserId}, dto); // sau response.payload.UserId
        }

     */
        // PUT api/<UserController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateUser(int id, UserUpdateDto updatedUser)
        {
            var command = _mapper.Map<UpdateUserCommand>(updatedUser);
            command.UserId = id;
            var response = await _mediator.Send(command);

            if (response == null)
                return NotFound();

            return NoContent();                     //?
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteUser(int id)
        {
            var command = new DeleteUserCommand() { UserId = id };
            var response = await _mediator.Send(command);

            if (response == null)
                return NotFound();

            return NoContent();
        }
      
    }
    }
