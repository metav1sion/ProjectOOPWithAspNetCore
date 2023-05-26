using System.ComponentModel.DataAnnotations;

namespace Proje_OOP.Entity
{
	public class Product
	{
		[Key]
		public int ID { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }
    }
}
