﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Data.Entities
{
    public class DeliverMethod : BaseEntity<int>
    {
        public DeliverMethod() { }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string DeliveryTime { get; set; }
        public decimal Price { get; set; }
    }

}