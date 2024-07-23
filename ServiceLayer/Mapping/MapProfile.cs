using AutoMapper;
using CoreLayer.DTOs.Product;
using CoreLayer.Models;

namespace ServiceLayer.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
