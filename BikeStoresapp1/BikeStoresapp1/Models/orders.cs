﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BikeStoresapp1.Models
{
    public partial class orders
    {
        public orders()
        {
            order_items = new HashSet<order_items>();
        }

        public int order_id { get; set; }
        public int? customer_id { get; set; }
        public byte order_status { get; set; }
        public DateTime order_date { get; set; }
        public DateTime required_date { get; set; }
        public DateTime? shipped_date { get; set; }
        public int store_id { get; set; }
        public int staff_id { get; set; }

        public virtual customers customer { get; set; }
        public virtual staffs staff { get; set; }
        public virtual stores store { get; set; }
        public virtual ICollection<order_items> order_items { get; set; }
    }
}