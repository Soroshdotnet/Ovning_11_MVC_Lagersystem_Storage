using System.ComponentModel.DataAnnotations;

namespace Storage.Models
{
    public class Product
    {
        public int Id { get; set; }

        [MaxLength(15)]
        public string Name { get; set; }

        [Range(0,100)]
        public int Price { get; set; }

        [DataType(DataType.Date)]
        public DateTime Orderdate { get; set; }

        [Required]
        public string Category { get; set; }
        public string Shelf { get; set; }

        [Display(Name = "Stock")]
        public int Count { get; set; }

        public string Description { get; set; }

        public int ActionResult {get; set;}

    }
}
