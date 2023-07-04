using AutoMapper;
using Conference.Service.Conferences.Models;

namespace Conference.Service.Conferences.Profiles
{
    internal class ConferenceProfile : Profile
    {
        public ConferenceProfile()
        {
            CreateMap<EditableConferenceInfoModel, ConferenceInfoModel>();
            CreateMap<ConferenceInfoModel, Domain.Conferences.Conference>();
        }
    }
}
