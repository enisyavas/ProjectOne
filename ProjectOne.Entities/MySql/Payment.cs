using ProjectOne.Contracts.Entity;

namespace ProjectOne.Entity.MySql{
    public class Payment : IPayment
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int UserId  { get; set; }
    }
}