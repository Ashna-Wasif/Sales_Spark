using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace Sales.Server.Model.Entities
{
    public class Products
    {
        [Key]
        public int prodId { get; set; }
        public string prodName { get; set; }
        public string prodCategory { get; set; }
        public string prodColor { get; set; }
        public string prodSize { get; set; }
        public int prodPrice { get; set; }
        public string prodMaterial { get; set; }
        public string prodBrand { get; set; }

    }
}
