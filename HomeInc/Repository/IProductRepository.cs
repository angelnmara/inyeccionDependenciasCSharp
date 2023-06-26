using DB.Modelo;

namespace HomeInc.Repository
{
    public interface IProductRepository
    {
        public Product save(Product product);
        public List<Product> findAll();
        public Product update(Product product);
        public Product delete(int id);
    }
}
