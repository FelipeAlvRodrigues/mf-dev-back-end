using mf_dev_back_end.Models;
using Microsoft.AspNetCore.Mvc;

namespace mf_dev_back_end.Controllers
{
    public class VeiculosController : Controller
    {
        private readonly AppDbContext _context;
        public VeiculosController(AppDbContext context ) {
            _context = context;
        }
    }
}
