using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Domain.Entities
{
    public class Service
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Title3 { get; set; }
        public string Title4 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string ImageUrl { get; set; }
    }
}
