using HomeInc.DTO;

namespace HomeInc.Services
{
    public interface IProductService
    {
        ProductDTO save(ProductDTO productDTO);
        List<ProductDTO> findAll();
        ProductDTO update(ProductDTO productDTO);
        ProductDTO delete(int id);
    }
}
