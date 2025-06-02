using BestStoreMVC.Models;
using BestStoreMVC.Services;
using BestStoreMVC.ViewModel;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace BestStoreMVC.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IWebHostEnvironment _environment;
        public ProductsController(ApplicationDbContext context, IWebHostEnvironment environment)
        {
            _context = context;
            _environment = environment;
        }
        public IActionResult Index()
        {
            var products = _context.Products.OrderByDescending(i => i.Id).ToList(); //Retrive all movies from the database
            return View(products);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View(new ProductViewModel());
        }

        [HttpPost]
        public IActionResult Create(ProductViewModel viewModel)
        {
            //Validate the input data using ModelState
            if (ModelState.IsValid)
            {
                // save the image file
                string newFileName = DateTime.Now.ToString("yyyyMMddHHmmssfff");
                newFileName += Path.GetExtension(viewModel.ImageFile!.FileName);

                string imageFullPath = _environment.WebRootPath + "/images/" + newFileName;
                using (var stream = System.IO.File.Create(imageFullPath))
                {
                    viewModel.ImageFile.CopyTo(stream);
                }

                //Map the view model to the Product entity
                var product = new Product
                {
                    Name = viewModel.Name,
                    Brand = viewModel.Brand,
                    Category = viewModel.Category,
                    Price = viewModel.Price,
                    Description = viewModel.Description,
                    ImageFileName = newFileName,
                    CreatedAt = DateTime.Now
                };

                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Index", "Products");
            }

            

            return View(viewModel);
        }

        public IActionResult Edit(int id)
        {
            var product = _context.Products.Find(id);

            if (product == null)
            {
                return RedirectToAction("Index", "Products");
            }

            // create productDto from product
            var productDto = new ProductViewModel
            {
                Name = product.Name,
                Brand = product.Brand,
                Category = product.Category,
                Price = product.Price,
                Description = product.Description
            };

            ViewData["ProductId"] = product.Id;
            ViewData["ImageFileName"] = product.ImageFileName;
            ViewData["CreatedAt"] = product.CreatedAt.ToString("MM/dd/yyyy");

            return View(productDto);
        }
    }
}
