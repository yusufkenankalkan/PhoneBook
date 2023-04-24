using AutoMapper;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;
using PhoneBookEntityLayer.ViewModels;

namespace PhoneBookBusinessLayer.ImplementationOfManagers
{
    public class MemberManager : Manager<MemberViewModel, Member, string>, IMemberManager
    {
        public MemberManager(IMemberRepository repo, IMapper mapper) : base(repo, mapper, null)
        {
        }
    }
}
