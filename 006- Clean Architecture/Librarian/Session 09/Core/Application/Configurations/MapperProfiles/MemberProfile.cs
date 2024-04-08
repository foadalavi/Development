using AutoMapper;

namespace Librarian.Application.Configurations.MapperProfiles
{
    public class MemberProfile:Profile
    {
        public MemberProfile()
        {
            CreateMap<Features.Member.Commands.UpdateMember.UpdateMemberRequest, Domain.Member>();
            CreateMap<Features.Member.Commands.CreateMember.CreateMemberRequest, Domain.Member>();
            CreateMap<Features.Member.Queries.GetAllMembers.MemberDto, Domain.Member>().ReverseMap();
            CreateMap<Features.Member.Queries.GetMemebrDetails.MemberDetailsDto, Domain.Member>();
        }
    }
}
