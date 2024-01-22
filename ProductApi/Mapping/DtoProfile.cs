using AutoMapper;
using ProductApi.Models.DTOs;
using ProductApi.Models.Products;


namespace ProductApi.Mapping;

    public class DtoProfile : Profile 
    {
        public DtoProfile()
        {

            CreateMap<Product, ProductDto>();
            CreateMap<Product, ProductAddDtoRequest>();
            
        
        }

    }

