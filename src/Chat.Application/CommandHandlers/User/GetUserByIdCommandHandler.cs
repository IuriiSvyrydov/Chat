
using Chat.Application.Commands.User;
using Chat.Infrastructure.Data;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Chat.Application.CommandHandlers.User
{
    public class GetUserByIdCommandHandler: IRequestHandler<GetUserByIdCommand,Domain.Entities.User>
    {
        public readonly ChatDbContext _context;

        public GetUserByIdCommandHandler(ChatDbContext context)
        {
            _context = context;
        }

        public async Task<Domain.Entities.User> Handle(GetUserByIdCommand request, CancellationToken cancellationToken)
        {
              return await _context.Users.FirstOrDefaultAsync(x => x.Id == request.Id);
        }
    }
}
