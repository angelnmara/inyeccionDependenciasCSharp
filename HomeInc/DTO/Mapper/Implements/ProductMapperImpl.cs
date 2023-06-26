using DB.Modelo;

namespace HomeInc.DTO.Mapper.Implements
{
    public class ProductMapperImpl : IProductMapper
    {
        public ProductDTO toDTO(Product product)
        {
            try {
                return new ProductDTO
                {
                    ProductCategory = product.ProductCategory,
                    ProductWarranty = product.ProductWarranty,
                    ProductID = product.ProductID,
                    ProductName = product.ProductName,
                    Date = product.Date,
                    User = product.User,
                };
            }catch (Exception ex) {
                throw new NotImplementedException();
            }            
        }

        public Product toEntity(ProductDTO productDTO)
        {
            try {
                return new Product
                {
                    ProductName = productDTO.ProductName,
                    Date = productDTO.Date,
                    ProductCategory = productDTO.ProductCategory,
                    ProductID= productDTO.ProductID,
                    User = productDTO.User,
                    ProductWarranty= productDTO.ProductWarranty,
                };
            }catch (Exception ex) { 
                throw new NotImplementedException();
            }            
        }

        public List<ProductDTO> toListDTO(List<Product> products)
        {
            try { 
                List<ProductDTO> productDTOs = new List<ProductDTO>();
                foreach (Product product in products)
                {
                    productDTOs.Add(toDTO(product));
                }
                return productDTOs;
            } catch (Exception ex) {
                throw new NotImplementedException();
            }
            
        }
    }
}
