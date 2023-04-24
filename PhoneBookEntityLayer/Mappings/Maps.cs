using AutoMapper;
using PhoneBookEntityLayer.Entities;
using PhoneBookEntityLayer.ViewModels;

namespace PhoneBookEntityLayer.Mappings
{
    public class Maps : Profile
    {
        public Maps()
        {
            CreateMap<Member, MemberViewModel>();
            CreateMap<MemberViewModel,Member>();

            CreateMap<PhoneType, PhoneTypeViewModel>().ReverseMap();
            CreateMap<MemberPhone, MemberPhoneViewModel>().ReverseMap();
        }
    }
}
