using AutoMapper;
using Conference.Application.Conferences.Commands;
using Conference.Application.Conferences.Queries;
using Conference.Service.Conferences.Events;
using Conference.Service.Conferences.Models;
using MediatR;
using System.Data;

namespace Conference.Service.Conferences
{
    public class ConferenceService
    {
        private readonly IMediator mediator;
        private readonly IMapper mapper;

        public ConferenceService(IMediator mediator, IMapper mapper)
        {
            this.mediator = mediator;
            this.mapper = mapper;
        }

        public async Task CreateConference(ConferenceInfoModel conferenceInfoModel)
        {
            var conference = await mediator.Send(new GetConferenceQuery(new SearchConference
            {
                BySlug = conferenceInfoModel.Slug
            }));

            if (conference is null)
            {
                throw new DuplicateNameException($"The chosen conference slug=[{conferenceInfoModel.Slug}] is already taken.");
            }

            // Conference publishing is explicit. 
            if (conferenceInfoModel.IsPublished)
            {
                conferenceInfoModel.IsPublished = false;
            }

            await mediator.Send(new AddConferenceCommand(mapper.Map<Domain.Conferences.Conference>(conferenceInfoModel)));

            await mediator.Publish(new ConferenceCreatedEvent(mapper.Map<ConferenceInfoModel>(conference)));
        }
    }
}
