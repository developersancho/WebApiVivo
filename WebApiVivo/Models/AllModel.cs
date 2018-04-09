using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace WebApiVivo.Models
{
    [Table("All")]
    public class AllModel
    {
        [Key]
        public int Id { get; set; }
        public string Address { get; set; }
        public string Brand { get; set; }
        public string City { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Neighborhood { get; set; }
        public string Postcode { get; set; }
        public string Town { get; set; }
        public string Type { get; set; }
        public string XCoor { get; set; }
        public string YCoor { get; set; }
    }
}