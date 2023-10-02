using API_TeamsData.Dtos.Times;
using API_TeamsData.Models;
using AutoMapper;

namespace API_TeamsData.Profiles
{
    public class TimesProfiles : Profile
    {
        public TimesProfiles()
        {
            CreateMap<CreateTimesDtos, Times>();
        }

    }
}
