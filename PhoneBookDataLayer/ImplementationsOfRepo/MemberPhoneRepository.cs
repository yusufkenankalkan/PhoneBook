using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;

namespace PhoneBookDataLayer.ImplementationsOfRepo
{
    public class MemberPhoneRepository : Repository<MemberPhone, int>, IMemberPhoneRepository
    {
        public MemberPhoneRepository(MyContext context) : base(context)
        {
        }
    }
}
