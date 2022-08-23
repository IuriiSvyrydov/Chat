
using Chat.Application.Dtos;
using MediatR;

namespace Chat.Application.Commands.User
{
    public class GetUserByIdCommand: IRequest<Domain.Entities.User>
    {
        public Guid Id { get; set; }
    }
}
