using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Order
    {
        [Key]
        public int OrderId { get; set; }
        public string Name { get; set; }
        public string Adress { get; set; }
        public string PhoneNumber { get; set; }

        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
