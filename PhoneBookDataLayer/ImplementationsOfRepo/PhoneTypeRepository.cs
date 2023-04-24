using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;

namespace PhoneBookDataLayer.ImplementationsOfRepo
{
    public class PhoneTypeRepository : Repository<PhoneType, byte>, IPhoneTypeRepository
    {
        public PhoneTypeRepository(MyContext context) : base(context)
        {
        }
    }
}
