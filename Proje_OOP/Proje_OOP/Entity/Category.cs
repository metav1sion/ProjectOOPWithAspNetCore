﻿using System.ComponentModel.DataAnnotations;

namespace Proje_OOP.Entity
{
	public class Category
	{
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }
    }
}
