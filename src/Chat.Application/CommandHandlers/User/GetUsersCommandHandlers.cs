

using AutoMapper;
using Chat.Application.Commands.User;
using Chat.Application.Dtos;
using Chat.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Chat.Application.CommandHandlers.User
{
    public class GetUsersCommandHandlers: IRequestHandler<GetUsersCommand,IEnumerable<Domain.Entities.User>>
    {
        private readonly ChatDbContext _context;
        private IMapper _mapper;

        public GetUsersCommandHandlers(ChatDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public async Task<IEnumerable<Domain.Entities.User>> Handle(GetUsersCommand request, CancellationToken cancellationToken)
        {
            return await _context.Users.ToListAsync(cancellationToken: cancellationToken);
        }
    }
}
