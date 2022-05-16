using BlogYonetimi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace BlogYonetimi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly BlogContext _context; //blogcontextin içinde  category ye git ve database addcategoryi ekle.

        public HomeController(ILogger<HomeController> logger, BlogContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Login(string Email,string Password)
        {
            var yazar = _context.Yazar.FirstOrDefault(w => w.Email == Email && w.Password == Password);
            if (yazar==null)
            {
                return RedirectToAction(nameof(Index));
            }

            HttpContext.Session.SetInt32("id",yazar.id);
            return RedirectToAction(nameof(Category));
        }

        public async Task<IActionResult>AddCategory(Category category) //değişken türettik category adında.//asenkron belli bi sıranın olmadığı işlemlerin birbirini beklemediği kod akışının işlem durumularına göre devam ettiği  
        {
            await _context.AddAsync(category);//
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Category));//tekrar kategoriye dönüş yapsıb 
        }
        public IActionResult Category()
        {
            List<Category> List = _context.Category.ToList();
            return View(List);
        }

        public async Task<IActionResult>DeleteCategory(int? id)
        {
            Category category = await _context.Category.FindAsync(id);
            _context.Remove(category);
            await _context.SaveChangesAsync();//await iki işlem arasında bekleme yapıyodu
            return RedirectToAction(nameof(Category));
        }
         
        public IActionResult Yazar()
        {
            List<Yazar> List = _context.Yazar.ToList();
            return View(List);
        }

        public async Task<IActionResult>AddYazar(Yazar yazar)
        {
            await _context.AddAsync(yazar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Yazar));
        }
         

        public async Task<IActionResult>DeleteYazar(int? id)
        {
            Yazar yazar = await _context.Yazar.FindAsync(id);
            _context.Remove(yazar);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Yazar));
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
