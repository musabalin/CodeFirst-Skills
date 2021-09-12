using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirstEntity_Skills_.Models.Classes
{
    public class SKILLS
    {
        [Key]
        public int ID { get; set; }
        public string Description { get; set; }
        public byte Value { get; set; }
    }
}