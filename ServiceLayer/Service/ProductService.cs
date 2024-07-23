using AutoMapper;
using CoreLayer.Models;
using CoreLayer.Repositories;
using CoreLayer.Service;
using CoreLayer.UnitOfWorks;

namespace ServiceLayer.Service
{
    public class ProductService : Service<Product>, IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IProductRepository productRepository, IMapper mapper) : base(repository, unitOfWork)
        {
            _productRepository = productRepository;
            _mapper = mapper;
        }
    }
}
