using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DuxTeamAPI.Models
{
    public class DataDbInitializer : DropCreateDatabaseAlways<TimeConext>
    {
        protected override void Seed(TimeConext db)
        {
            db.DateAndTimes.Add(new Date { DateAndTime = "test" });
            db.DateAndTimes.Add(new Date { DateAndTime = "test1" });
            db.DateAndTimes.Add(new Date { DateAndTime = "test2" });

            base.Seed(db);
        }
    }
}