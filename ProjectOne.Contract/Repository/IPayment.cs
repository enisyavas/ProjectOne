namespace ProjectOne.Contract
{
    public interface IPayment
    {
        int Id { get; set; }
        int ProductId { get; set; }
        int UserId { get; set; }
    }
}