using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace calhfAPI.data
{
    public class CalhfContext : DbContext
    {
        public CalhfContext(DbContextOptions<CalhfContext> code) : base(code)
        {

        }
        public DbSet<tblStatus> tblStatus { get; set; }

    }
}
