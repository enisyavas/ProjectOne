namespace ProjectOne.Contract
{
    public interface IUser
    {
        int Id { get; set; }
        string Name { get; set; }
        string Surname { get; set; }
        string Phone { get; set; }
    }
}