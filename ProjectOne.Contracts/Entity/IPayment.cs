namespace ProjectOne.Contracts.Entity
{
    public interface IPayment
    {
        int Id { get; set; }
        int ProductId { get; set; }
        int UserId { get; set; }
    }
}