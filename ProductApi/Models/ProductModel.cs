using System.ComponentModel.DataAnnotations;
namespace ProductApi.Models;
public class ProductModel
{
    [Key]
    public int Id { get; set; }
    public string? ProductName { get; set; }
    public string? ProductPrice { get; set; }
    public DateTime MfgDate { get; set; }
}