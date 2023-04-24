using Microsoft.AspNetCore.Mvc;
using PhoneBookBusinessLayer.InterfacesOfManagers;
using PhoneBookUI.Areas.Admin.Models;

namespace PhoneBookUI.Areas.Admin.Components;

public class AdminLeftMenu : ViewComponent
{
    private readonly IMemberManager _memberManager;
    private readonly IPhoneTypeManager _phoneTypeManager;
    private readonly IMemberPhoneManager _memberPhoneManager;
    //Eğer email gönderimi yapılacaksa buraya IEmailSender eklenmelidir.

    public AdminLeftMenu(IMemberManager memberManager, IPhoneTypeManager phoneTypeManager, IMemberPhoneManager memberPhoneManager)
    {
        _memberManager = memberManager;
        _phoneTypeManager = phoneTypeManager;
        _memberPhoneManager = memberPhoneManager;
    }

    public IViewComponentResult Invoke()
    {
        try
        {
            AdminLeftMenuDataCountModel model = new AdminLeftMenuDataCountModel()
            {
                //Toplam üye sayısı
                TotalMemberCount = _memberManager.GetAll().Data.Count,
                //Toplam Telefon tipi sayısı
                TotalPhoneTypeCount = _phoneTypeManager.GetAll().Data.Count,
                //Toplam numara sayısı
                TotalContactNumberCount = _memberPhoneManager.GetAll().Data.Count
            };
            return View(model);
        }
        catch (Exception ex)
        {
            // TempData ile burada oluşan hata gönderilebilir.
            return View(new AdminLeftMenuDataCountModel());
        }
    }
}
