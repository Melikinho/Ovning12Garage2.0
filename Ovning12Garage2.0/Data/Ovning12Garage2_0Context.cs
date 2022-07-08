using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ovning12Garage2._0.Models;

namespace Ovning12Garage2._0.Data
{
    public class Ovning12Garage2_0Context : DbContext
    {
        public Ovning12Garage2_0Context (DbContextOptions<Ovning12Garage2_0Context> options)
            : base(options)
        {
        }

        public DbSet<Ovning12Garage2._0.Models.ParkedVehicle>? ParkedVehicle { get; set; }
    }
}
