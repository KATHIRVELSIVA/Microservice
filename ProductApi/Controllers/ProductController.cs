using Microsoft.AspNetCore.Mvc;
namespace ProductApi.Controllers;
using ProductApi.Models;
using ProductApi.Data;
using Microsoft.EntityFrameworkCore;

[ApiController]
public class ProductController : ControllerBase
{
    private readonly AppDbContext _context;
    public ProductController(AppDbContext context)
    {
        _context = context;
    }
    [Route("GetProductList")]
    [HttpGet]
    public async Task<IEnumerable<ProductModel>> GetProductList()
    {
        return await _context.Products.ToListAsync();
    }
    // [Route("GetSingle")]
    // [HttpGet("{id}")]
    // public async Task<IActionResult> GetSingle(int id)
    // {
    //     if (id < 1)
    //         return BadRequest();
    //     var doctor = await _context.Products.FirstOrDefaultAsync(m => m.Id == id);
    //     if (doctor == null)
    //         return NotFound();
    //     return Ok(doctor);
    // }
    // [HttpPost]
    // public async Task<IActionResult> Post(ProductModel product)
    // {
    //     _context.Add(product);
    //     await _context.SaveChangesAsync();
    //     return Ok();
    // }
    // [HttpPut]
    // public async Task<IActionResult> Put(ProductModel productdata)
    // {
    //     if (productdata == null || productdata.Id == 0)
    //         return BadRequest();

    //     var product = await _context.Products.FindAsync(productdata.Id);
    //     if (product == null)
    //         return NotFound();
    //     product.ProductName = productdata.ProductName;
    //     product.ProductPrice = productdata.ProductPrice;
    //     product.MfgDate = productdata.MfgDate;
    //     await _context.SaveChangesAsync();
    //     return Ok();
    // }
    // [HttpDelete("{id}")]
    // public async Task<IActionResult> Delete(int id)
    // {
    //     if (id < 1)
    //         return BadRequest();
    //     var product = await _context.Products.FindAsync(id);
    //     if (product == null)
    //         return NotFound();
    //     _context.Products.Remove(product);
    //     await _context.SaveChangesAsync();
    //     return Ok();
    // }
}

