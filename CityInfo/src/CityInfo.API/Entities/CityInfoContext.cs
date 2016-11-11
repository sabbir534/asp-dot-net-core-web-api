﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CityInfo.API.Entities
{
    public class CityInfoContext:DbContext
    {
        public CityInfoContext(DbContextOptions<CityInfoContext> options)
            :base(options)
        {
            Database.Migrate();
        }
        public DbSet<City> Cities { get; set; }
        public DbSet<PointOfInterest> PointsOfInterest { get; set; }

    }
}
