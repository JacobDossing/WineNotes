﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WineNotes.Persistance.Contexts {
    public class AppDbContext : DbContext{

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){
        }


    }
}
