using Conference.Service.Conferences.Models;
using MediatR;

namespace Conference.Service.Conferences.Events
{
    public record ConferenceCreatedEvent(ConferenceInfoModel Conference) : INotification;
}
