using AutoMapper;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;
using PhoneBookEntityLayer.ViewModels;

namespace PhoneBookBusinessLayer.ImplementationOfManagers
{
    public class MemberPhoneManager : Manager<MemberPhoneViewModel, MemberPhone, int>, IMemberPhoneManager
    {
        public MemberPhoneManager(IMemberPhoneRepository repo, IMapper mapper) : base(repo, mapper, "PhoneType,Member")
        {
        }
    }
}
