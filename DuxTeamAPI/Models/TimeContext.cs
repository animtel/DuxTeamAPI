using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DuxTeamAPI.Models
{
    public class TimeConext: DbContext
    {
        public DbSet<Date> DateAndTimes { get; set; }
    }
}