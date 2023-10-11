using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Domain.Entities
{
    public class About
    {
        public int Id { get; set; }
        public string ImageUrl1 { get; set; }
        public string ImageUrl2 { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description { get; set; }
        public string District { get; set; }
        public string Street { get; set; }
        public string City { get; set; }
    }
}
