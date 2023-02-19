using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PractisingImageUpload.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Hosting;
using System.IO;
using Microsoft.Extensions.FileProviders;
using System.Data.SqlClient;
using System.Data;
using static System.Net.Mime.MediaTypeNames;

namespace PractisingImageUpload.Controllers
{
    public class Home : Controller
    {

       
        private readonly ILogger<Home> _logger;
        public Home(ILogger<Home> logger)
        {
            _logger = logger;

        }

        public IActionResult Index()
        {
            ProductDataAccessLayer jj = new ProductDataAccessLayer();
            jj.ViewAllStoreProducts();





            return View(jj);

        }
       
        [HttpGet]
        public IActionResult CreateNewProduct()
        {
            ProductDataAccessLayer TheNewProduct = new ProductDataAccessLayer();
            TheNewProduct.ProductImageLocation = "";
            TheNewProduct.ProductName = "";
            TheNewProduct.ProductDescription = "";
            TheNewProduct.ProductPrice = 0;


            return View(TheNewProduct);
        }
        [HttpPost]
        public IActionResult CreateNewProduct(IFormFile TheUploadedFile, string TheProductsName, string TheProductsDescription, string TheProductsPrice)
        {

            ProductDataAccessLayer TheNewProduct = new ProductDataAccessLayer();
            TheNewProduct.ProductName = TheProductsName;
            TheNewProduct.ProductDescription = TheProductsDescription;
            TheNewProduct.ProductPrice = int.Parse(TheProductsPrice);

            


            using (var md = new MemoryStream())//(Ingrom, s.a).
            {
                TheUploadedFile.CopyTo(md);//(Ingrom, s.a).
                var convertedimage = md.ToArray();//(Ingrom, s.a).
                byte[] OO = convertedimage;
                TheNewProduct.ProductImageData = OO;

            }

            TheNewProduct.CreateANewProduct();


                return View(TheNewProduct);
        }
    
        [HttpGet]
        public IActionResult RemoveProduct()
        {
            ProductDataAccessLayer ProductRemoval = new ProductDataAccessLayer();
            ProductRemoval.ProductName = "";
            return View(ProductRemoval);
        }
        [HttpPost]
        public IActionResult RemoveProduct(string ProductThatNeedsToBeRemoved)
        {
            ProductDataAccessLayer ProductRemoval = new ProductDataAccessLayer();
            ProductRemoval.ProductName = ProductThatNeedsToBeRemoved;

            ProductRemoval.RemoveAProduct();

            return View(ProductRemoval);
        }
        [HttpGet]
        public IActionResult UpdateProduct()
        {
            ProductDataAccessLayer UpdateProduct = new ProductDataAccessLayer();
            UpdateProduct.ProductImageLocation = "";
            UpdateProduct.ProductName = "";
            UpdateProduct.ProductDescription = "";
            UpdateProduct.ProductPrice = 0;


            return View(UpdateProduct);
        }
        [HttpPost]
        public IActionResult UpdateProduct(string ExistingProductName, IFormFile NewProductImage, string NewProductDescription, string NewProductPrice)
        {
            ProductDataAccessLayer UpdateProduct = new ProductDataAccessLayer();
            UpdateProduct.ProductName = ExistingProductName;
            UpdateProduct.ProductDescription = NewProductDescription;
            UpdateProduct.ProductPrice = int.Parse(NewProductPrice);

            

            using (var mc = new MemoryStream())//(Ingrom, s.a).
            {
                NewProductImage.CopyTo(mc);//(Ingrom, s.a).
                var convertedimage = mc.ToArray();//(Ingrom, s.a).
                byte[] OK = convertedimage;
                UpdateProduct.ProductImageData = OK;

            }

            UpdateProduct.UpdateAProduct();


            return View(UpdateProduct);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
