﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebProject.Domain.Entities.DBModels;
using WebProject.Domain.Entities.User;

using System.Data.Entity;

namespace WebProject.Domain
{
    public class DB //ваще по хорошему такие вещи нужно пихать в internal
    {
        public class Context : DbContext
        {
            public DbSet<ProductDataEF> Products { get; set; }
            public DbSet<CategoryTypeEF> CategoryTypes { get; set; }
            public Context() : base(Constants.SqlConnectionSQLServer) //подключение к mdl3.bayracraft.co.in
            {

            }
        }
    }
}