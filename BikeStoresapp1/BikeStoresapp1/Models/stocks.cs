﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BikeStoresapp1.Models
{
    public partial class stocks
    {
        public int store_id { get; set; }
        public int product_id { get; set; }
        public int? quantity { get; set; }

        public virtual products product { get; set; }
        public virtual stores store { get; set; }
    }
}