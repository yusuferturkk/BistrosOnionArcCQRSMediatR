using Bistros.Core.Application.Dtos.Category;
using Bistros.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Dtos.Food
{
    public class ResultFoodDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public ResultCategoryNoFoodsDto Category { get; set; }
    }
}
