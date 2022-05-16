﻿using BlogYonetimi.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlogYonetimi.Controllers
{
    public class BlogController : Controller
    {
        private readonly ILogger<BlogController> _logger;
        private readonly BlogContext _context; //blogcontextin içinde  category ye git ve database addcategoryi ekle.

        public BlogController(ILogger<BlogController> logger, BlogContext context)
        {
            _logger = logger;
            _context = context;
        }
        public async Task<IActionResult> Save(Blog model)
        {
            if (model != null)
            {
                var file = Request.Form.Files.First();
                //C:\Users\90553\Desktop\KisiselBlog\KisiselBlog\wwwroot\assets\img
                string savePath = Path.Combine("C:", "Users", "90553", "Desktop", "KisiselBlog", "KisiselBlog", "wwwroot", "assets",  "img");
                var fileName = $"{DateTime.Now:MMddHHmmss}.{file.FileName.Split(".").Last()}";
                var fileUrl = Path.Combine(savePath, fileName);
                using (var fileStream = new FileStream(fileUrl, FileMode.Create))
                {
                    await file.CopyToAsync(fileStream);
                }
                model.ImagePath = fileName;
                model.Yazarid = (int)HttpContext.Session.GetInt32("id");
                await _context.AddAsync(model);
                await _context.SaveChangesAsync();
                return Json(true);

            }

            return Json(false);

        }

        public IActionResult Index()
        {
            var list = _context.Blog.ToList();
            return View(list);


        }
        //yayınlama=publish blogu yayınla
        public IActionResult Publish(int Id)
        {
            var blog = _context.Blog.Find(Id);
            blog.IsPublish = true;
            _context.Update(blog);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));//RedirectToAction=ındex sayfasına yönlendirme
        }

        public IActionResult Blog()
        {
            ViewBag.Categories = _context.Category.Select(w =>  
             new SelectListItem
             {
                 Text = w.Name,// ıd ye göre isim çıkar
                 Value = w.CategoryId.ToString()//ıd göster 
             }
           ).ToList();

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
