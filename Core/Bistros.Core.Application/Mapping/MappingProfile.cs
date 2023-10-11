using AutoMapper;
using Bistros.Core.Application.Dtos.Category;
using Bistros.Core.Application.Dtos.Food;
using Bistros.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, ResultCategoryNoFoodsDto>().ReverseMap();
            CreateMap<Category, CreateCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

            CreateMap<Food, ResultFoodDto>().ReverseMap();
            CreateMap<Food, ResultFoodNoCategoryDto>().ReverseMap();
            CreateMap<Food, CreateFoodDto>().ReverseMap();
            CreateMap<Food, UpdateFoodDto>().ReverseMap();
        }
    }
}
