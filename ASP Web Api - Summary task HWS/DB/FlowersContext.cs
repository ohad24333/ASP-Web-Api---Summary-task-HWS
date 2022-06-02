using ASP_Web_Api___Summary_task_HWS.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_Web_Api___Summary_task_HWS.DB
{
    public class FlowersContext : DbContext
    {
        public FlowersContext(DbContextOptions<FlowersContext> options) : base(options)
        {

        }

        public DbSet<Flower> Flowers { get; set; }
    }
}
