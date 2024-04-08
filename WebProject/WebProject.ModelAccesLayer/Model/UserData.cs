﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Domain.Enum;
using WebProject.ModelAccessLayer.Model;

namespace WebProject.ModelAccessLayer.Model
{
    public class UserData
    {
        public int IdUser { get; set; }
        public string NameUser { get; set; }
        public CartData CartUser { get; set; }
        public AllDeliveries DeliveriesUser { get; set; }
        public AllProducts ProductsAdmin { get; set; }
        public AllDeliveries DeliveriesAdmin { get; set; }
        public StatusUser StatusUser { get; set; }
        public bool IsAuthorized { get; set; }

        public UserData()
        {
            CartUser = new CartData();
            DeliveriesUser = new AllDeliveries();
            StatusUser = StatusUser.Unknown;
            ProductsAdmin = new AllProducts();
            DeliveriesAdmin = new AllDeliveries();
        }
    }
}