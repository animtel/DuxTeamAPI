using DuxTeamAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace DuxTeamAPI.Controllers
{
    public class ValuesController : ApiController
    {
        TimeConext db = new TimeConext();

        public IEnumerable<Date> GetDate()
        {
            return db.DateAndTimes;
        }

        public Date GetDate(int id)
        {
            Date date = db.DateAndTimes.Find(id);
            return date;
        }


        [HttpGet]
        public void CreateDate(string date)
        {
            db.DateAndTimes.Add(new Date { DateAndTime = $"{date}" });
            db.SaveChanges();
        }
        
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
