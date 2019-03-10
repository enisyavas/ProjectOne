using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using ProjectOne.Contracts.Entity;
namespace ProjectOne.Entity.MySql{
    [Table("user")]
    public class User : IUser
    {
        [Key,Column("id")]
        public int Id { get; set; }
        [Column("name")]
        public string Name { get; set; }
        [Column("surname")]
        public string Surname { get; set; }
        [Column("phone")]
        public string Phone { get; set; }
    }
}