using ProjectOne.Contracts.Entity;

namespace ProjectOne.Entity.MySql{
    public class User : IUser
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Phone { get; set; }
    }
}