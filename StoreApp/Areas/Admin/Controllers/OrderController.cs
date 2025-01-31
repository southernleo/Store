using Microsoft.AspNetCore.Mvc;
using Services.Contracts;

namespace StroreApp.Areas.Admin.Controllers{

    [Area("Admin")]
    public class OrderController : Controller{

        private readonly IServiceManager _manager;

        public OrderController(IServiceManager manager)
        {
            _manager = manager;
        }
        public ActionResult Index(){
            var orders=_manager.OrderService.Orders.ToList();;
            return View(orders);
        }
        public IActionResult Complete([FromForm]int id){
            _manager.OrderService.Complete(id);
            return RedirectToAction("Index");
        }
    }
}