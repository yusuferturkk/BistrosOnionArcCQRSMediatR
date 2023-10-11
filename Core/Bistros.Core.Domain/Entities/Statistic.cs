﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bistros.Core.Domain.Entities
{
    public class Statistic
    {
        public int Id { get; set; }
        public string Title1 { get; set; }
        public string Title2 { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string StatisticTitle1 { get; set; }
        public string StatisticTitle2 { get; set; }
        public string StatisticTitle3 { get; set; }
        public int StatisticCount1 { get; set; }
        public int StatisticCount2 { get; set; }
        public int StatisticCount3 { get; set; }
    }
}
