using ProjectOne.Contracts.Repository;
using ProjectOne.Entity.MySql;

namespace ProjectOne.Repository
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private MySqlDbContext _dbContext;

        public RepositoryWrapper(MySqlDbContext context)
        {
            _dbContext = context;
        }

        private IRepository<User> _userRepository;
        private IRepository<Product> _productRepository;
        private IRepository<Payment> _paymentRepository;


        public IRepository<User> UserRepository => _userRepository ?? new GenericRepository<User>(_dbContext);

        public IRepository<Product> ProductRepository => _productRepository ?? new GenericRepository<Product>(_dbContext);

        public IRepository<Payment> PaymentRepository => _paymentRepository ?? new GenericRepository<Payment>(_dbContext);

    }
}