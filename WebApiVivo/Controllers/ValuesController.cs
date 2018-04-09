using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApiVivo.Models;

namespace WebApiVivo.Controllers
{

    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<AllModel> Get()
        {
            List<AllModel> allModels = new List<AllModel>();

            string path = System.Reflection.Assembly.GetExecutingAssembly().CodeBase;
            //once you have the path you get the directory with:
            var directory = System.IO.Path.GetDirectoryName(path);

            string p1 = System.IO.Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location);
            string p2 = System.Web.Hosting.HostingEnvironment.ApplicationPhysicalPath;

            using (var db = new VivoDbContext())
            {
                allModels = db.All.Where(x=>x.Type == "ATM").ToList();
            }

            return allModels;
        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
