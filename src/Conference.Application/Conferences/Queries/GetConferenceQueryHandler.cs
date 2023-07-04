using MediatR;

namespace Conference.Application.Conferences.Queries
{
    public class SearchConference
    {
        public string? BySlug { get; set; }
    }

    public record GetConferenceQuery(SearchConference Filter) : IRequest<Domain.Conferences.Conference>;
    internal class GetConferenceQueryHandler : IRequestHandler<GetConferenceQuery, Domain.Conferences.Conference>
    {
        public Task<Domain.Conferences.Conference> Handle(GetConferenceQuery request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
