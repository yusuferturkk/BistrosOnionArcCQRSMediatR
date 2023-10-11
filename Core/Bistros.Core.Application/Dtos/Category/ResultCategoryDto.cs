using Bistros.Core.Application.Dtos.Food;
using Bistros.Core.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Application.Dtos.Category
{
    public class ResultCategoryDto
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public List<ResultFoodNoCategoryDto>? Foods { get; set; }
    }
}
