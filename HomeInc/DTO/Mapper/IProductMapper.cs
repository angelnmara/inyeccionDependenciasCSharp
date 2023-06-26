using DB.Modelo;

namespace HomeInc.DTO.Mapper
{
    public interface IProductMapper
    {
        ProductDTO toDTO(Product product);
        Product toEntity(ProductDTO productDTO);
        List<ProductDTO> toListDTO(List<Product> products);

    }
}
