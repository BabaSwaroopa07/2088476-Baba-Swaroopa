using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Log4net2.Models;

namespace Log4net2.Data
{
    public class Log4netLoggingUsageContext : DbContext
    {
        public Log4netLoggingUsageContext (DbContextOptions<Log4netLoggingUsageContext> options)
            : base(options)
        {
        }

        public DbSet<Log4net2.Models.Account> Account { get; set; }
    }
}
