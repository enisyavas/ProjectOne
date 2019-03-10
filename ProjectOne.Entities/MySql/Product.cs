using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectOne.Contracts.Entity;

namespace ProjectOne.Entity.MySql
{
    [Table("product")]
    public class Product : IProduct
    {
        [Key,Column("id")]
        public int Id { get; set; }
        [Column("title")]
        public string Title { get; set; }
        [Column("price")]
        public double Price { get; set; }
        [Column("create_date")]
        public DateTime CreateDate { get; set; }
    }
}