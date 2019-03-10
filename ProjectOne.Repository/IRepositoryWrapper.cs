using ProjectOne.Contracts.Repository;
using ProjectOne.Entity.MySql;
namespace ProjectOne.Repository
{
    public interface IRepositoryWrapper
    {
        IRepository<User> UserRepository { get; }
        IRepository<Product> ProductRepository{get;}
        IRepository<Payment> PaymentRepository{get;}
    }

}