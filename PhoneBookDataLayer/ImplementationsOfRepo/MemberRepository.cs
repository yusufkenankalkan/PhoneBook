using PhoneBookDataLayer.InterfacesOfRepo;
using PhoneBookEntityLayer.Entities;

namespace PhoneBookDataLayer.ImplementationsOfRepo
{
    public class MemberRepository : Repository<Member, string>, IMemberRepository
    {
        public MemberRepository(MyContext context) : base(context)
        {
            //Kalıtım aldığı atasındaki ctor bir parametre aldığı için burada o parametreyi kendisine ilettik.
        }
        //_context burada kullanılabilir çünkü repositoryde protected olarak yazıldı.
    }
}