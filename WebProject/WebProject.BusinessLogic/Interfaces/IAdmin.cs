﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.ModelAccessLayer.Model;


namespace WebProject.BusinessLogic.Interfaces
{
    public interface IAdmin
    {
        bool AddProduct(Product product);
        bool DeleteProduct(Product product);
        bool EditProduct(Product updatedProduct);
        AllProducts GetAllProducts();
        AllDeliveries GetAllActiveOrder();
        bool DeleteOrderModel(OrderModel orderModel);
    }
}
