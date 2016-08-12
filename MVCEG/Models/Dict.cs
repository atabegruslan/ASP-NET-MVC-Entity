using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCEG.Models
{
    [Table("MvcEg")]
    public class Dict
    {
        [Key]
        public string Key { get; set; }

        public string Value { get; set; }
    }
}