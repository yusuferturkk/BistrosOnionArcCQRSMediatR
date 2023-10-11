﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Domain.Entities
{
    public class Banner
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string SubTitle1 { get; set; }
        public string ImageUrl1 { get; set; }
        public string SubTitle2 { get; set; }
        public string ImageUrl2 { get; set; }
    }
}
