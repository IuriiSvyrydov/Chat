

namespace Chat.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        
        private readonly IMediator _mediator;
        private IMapper _mapper;

        public UserController( IMediator mediator, IMapper mapper)
        {
            _mediator = mediator;
            _mapper = mapper;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<User>>> GetAll()
        {
            var query = new GetUsersCommand();
            var response = await _mediator.Send(query);
            var profile = _mapper.Map<IEnumerable<User>>(response);
            return Ok(profile);
        }
        [HttpGet]
        [Route("{id}")]
        public async Task<ActionResult<User>> GetUser(string id)
        {
            var userId = Guid.Parse(id);
            var query = new GetUserByIdCommand
            {
                Id = userId
            };
            var result =  await _mediator.Send(query);
            var mapped = _mapper.Map<User>(result);
            return Ok(mapped);

        }
    }
}
