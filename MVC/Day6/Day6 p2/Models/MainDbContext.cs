﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Day6.Models
{
    public class MainDbContext : DbContext
    {
        public MainDbContext() : base("myConn")
        {

        }
        public DbSet<Client> Clients { get; set; }


    }
}