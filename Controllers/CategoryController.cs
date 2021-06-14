using Bakery.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Bakery.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly ILogger<CategoryController> _logger;

        public CategoryController(ILogger<CategoryController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<Category> Get()
        {
            var rng = new Random();
            return Enumerable.Range(1, 5).Select(index => new Category(
                Id: "test1234",
                Name: "Patata",
                Description: "Esto es una categoría de pruebas",
                Products: new[]
                {
                    new Product(
                        Id: "coca1234",
                        Name: "Coca en llanda",
                        Description: "Coca en llanda",
                        Price: 6,
                        Currency: "EUR",
                        Unit: "KG"
                    )
                }.AsEnumerable()
            ))
            .ToArray();
        }
    }
}
