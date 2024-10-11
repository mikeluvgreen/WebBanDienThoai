using Microsoft.AspNetCore.Mvc;

namespace WebBanDienThoai.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
