using AutoMapper;
using Store.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Store.Service.Services.ProductBrandServices.DTOs
{
    public class ProductBrandProfile : Profile
    {
        public ProductBrandProfile()
        {
            CreateMap<ProductBrand, ProductBrandDetailsDto>();
        }
    }
}