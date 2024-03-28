﻿using Microsoft.AspNetCore.Mvc;
using MVCDemoCSharp_45.Data;

namespace MVCDemoCSharp_45.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductRepository _repo;

        public ProductController(IProductRepository repo)
        {
            _repo = repo;
        }
        public IActionResult Index()
        {
            var products = _repo.GetAllProducts();
            return View(products);
        }
    }
}
