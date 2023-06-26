using HomeInc.DTO;
using HomeInc.DTO.Mapper;
using HomeInc.Repository;

namespace HomeInc.Services.Implements
{
    public class ProductServiceImpl : IProductService
    {
        private readonly IProductRepository _repository;
        private readonly IProductMapper _mapper;

        public ProductServiceImpl(IProductRepository repository, IProductMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public ProductDTO delete(int id)
        {
            try { 
                return _mapper.toDTO(_repository.delete(id));
            }catch {
                throw new NotImplementedException();
            }            
        }

        public List<ProductDTO> findAll()
        {
            try { 
                return _mapper.toListDTO(_repository.findAll());
            }catch {
                throw new NotImplementedException();
            }            
        }

        public ProductDTO save(ProductDTO productDTO)
        {
            try {
                return _mapper.toDTO(_repository.save(_mapper.toEntity(productDTO)));
            } catch {
                throw new NotImplementedException();
            }            
        }

        public ProductDTO update(ProductDTO productDTO)
        {
            try {
                return _mapper.toDTO(_repository.update(_mapper.toEntity(productDTO)));
            } catch {
                throw new NotImplementedException();
            }            
        }
    }
}
