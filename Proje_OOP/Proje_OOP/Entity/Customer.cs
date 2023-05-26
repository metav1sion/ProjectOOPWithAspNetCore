﻿using System.ComponentModel.DataAnnotations;

namespace Proje_OOP.Entity
{
	public class Customer
	{
		[Key]
		public int ID { get; set; }
        public string Name { get; set; }
        public string City { get; set; }
    }
}
