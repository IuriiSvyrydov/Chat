

using MediatR;

namespace Chat.Application.Commands.User;

    public class GetUsersCommand: IRequest<IEnumerable<Domain.Entities.User>>
    {
    }
