using DB;
using DB.Modelo;

namespace HomeInc.Repository.Implements
{
    public class ProductRepositoryImpl : IProductRepository
    {
        private readonly HomeIncContext homeIncContext;

        public ProductRepositoryImpl(HomeIncContext homeIncContext)
        {
            this.homeIncContext = homeIncContext;
        }

        public Product delete(int id)
        {
            try { 
                Product product = homeIncContext.Products.Find(id);
                homeIncContext.Remove(product);
                return product;
            } catch {
                throw new NotImplementedException();
            }            
        }

        public List<Product> findAll()
        {
            try { 
                return homeIncContext.Products.ToList();
            } catch {
                throw new NotImplementedException();
            }            
        }

        public Product save(Product product)
        {
            try {
                homeIncContext.Add(product);
                homeIncContext.SaveChanges();
                return product;
            }catch {
                throw new NotImplementedException();
            }            
        }

        public Product update(Product product)
        {
            try { 
                homeIncContext.Update(product);
                homeIncContext.SaveChanges();
                return product; 
            } catch {
                throw new NotImplementedException();
            }            
        }
    }
}
