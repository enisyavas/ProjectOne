using System;
using ProjectOne.Contracts.Entity;

namespace ProjectOne.Entity.MySql
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public double Price { get; set; }
        public DateTime CreateDate { get; set; }
    }
}