﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace BikeStoresapp1.Models
{
    public partial class stores
    {
        public stores()
        {
            orders = new HashSet<orders>();
            staffs = new HashSet<staffs>();
            stocks = new HashSet<stocks>();
        }

        public int store_id { get; set; }
        public string store_name { get; set; }
        public string phone { get; set; }
        public string email { get; set; }
        public string street { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string zip_code { get; set; }

        public virtual ICollection<orders> orders { get; set; }
        public virtual ICollection<staffs> staffs { get; set; }
        public virtual ICollection<stocks> stocks { get; set; }
    }
}