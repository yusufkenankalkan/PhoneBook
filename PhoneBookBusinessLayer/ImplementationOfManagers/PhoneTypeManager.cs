using AutoMapper;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;
using PhoneBookEntityLayer.ViewModels;

namespace PhoneBookBusinessLayer.ImplementationOfManagers
{
    public class PhoneTypeManager : Manager<PhoneTypeViewModel, PhoneType, byte>, IPhoneTypeManager
    {
        public PhoneTypeManager(IPhoneTypeRepository repo, IMapper mapper) : base(repo, mapper, null)
        {
        }
    }
}
