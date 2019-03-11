using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectOne.Contracts.Entity;

namespace ProjectOne.Entity.MySql{
    [Table("payment")]
    public class Payment : IPayment
    {
        [Key,Column("id")]
        public int Id { get; set; }
        [Column("product_id")]
        public int ProductId { get; set; }
        [Column("user_id")]
        public int UserId  { get; set; }
    }
}