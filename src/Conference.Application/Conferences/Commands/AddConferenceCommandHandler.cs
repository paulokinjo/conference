using MediatR;

namespace Conference.Application.Conferences.Commands
{
    public record AddConferenceCommand(Domain.Conferences.Conference Conference):IRequest;
    internal class AddConferenceCommandHandler : IRequestHandler<AddConferenceCommand>
    {
        public Task Handle(AddConferenceCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
