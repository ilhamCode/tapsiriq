using Freelancer.Data;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Freelancer.Areas.admin.Controllers
{
    [Area("admin")]
    public class Portfolio : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _webHostEnvironment;
        public Portfolio(AppDbContext context,IWebHostEnvironment webHostEnvironment)
        {
            _context = context;
            _webHostEnvironment = webHostEnvironment;
        }


        public IActionResult Index()
        {
            List<Models.Portfolio> portfolios = _context.Portfolios.ToList();
            return View(portfolios);
        }

        public IActionResult create() {

            return View();
        }
        [HttpPost]
        public IActionResult create(Models.Portfolio portfolio) {
            if (ModelState.IsValid)
            {
                if (portfolio.ImageFile.ContentType == "image/jpeg" || portfolio.ImageFile.ContentType == "image/png")
                {
                    if (portfolio.ImageFile.Length <= 3145728)
                    {
                        string fileName = Guid.NewGuid() + "-" + portfolio.ImageFile.FileName;
                        string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "Uploads", fileName);

                        using (var stream = new FileStream(filePath, FileMode.Create))
                        {
                            portfolio.ImageFile.CopyTo(stream);
                        }

                        portfolio.Image = fileName;
                        _context.Portfolios.Add(portfolio);
                        _context.SaveChanges();

                        return RedirectToAction("index");
                    }
                    else
                    {
                        ModelState.AddModelError("", "The limit is 3mb");
                        return View(portfolio);
                    }
                }
                else
                {
                    ModelState.AddModelError("", "You can only upload image file!");
                    return View(portfolio);
                }
            }
            else
            {
                return View(portfolio);
            }
        }


    } 
}

