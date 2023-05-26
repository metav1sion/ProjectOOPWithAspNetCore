using Microsoft.EntityFrameworkCore;
using Proje_OOP.Entity;

namespace Proje_OOP.ProjeContext
{
	public class Context:DbContext
	{
		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=DESKTOP-JTNUQFE\\SQLEXPRESS;database=DbNewOOPCore2;integrated security=true;");
		}


		public DbSet<Product> products { get; set; }
		public DbSet<Customer> customers { get; set; }
		public DbSet<Category> categories { get; set; }
	}
}
