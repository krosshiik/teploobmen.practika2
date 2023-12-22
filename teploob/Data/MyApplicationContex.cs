﻿using Microsoft.EntityFrameworkCore;

namespace teploob.Data
{
    public class MyApplicationContex : DbContext
    {
        public DbSet<InputData> InputDatas { get; set; }

        public DbSet<User> Users { get; set; }

        public MyApplicationContex(DbContextOptions<MyApplicationContex> options) : base(options) 
        {

        }
    }
}
