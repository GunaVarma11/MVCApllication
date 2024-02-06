using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _6th_feb_school_database_project.Models
{
    [Table("Class")]
    public class Class
    {
   
            [Key]
            public int ClassId { get; set; }
            public string ClassName { get; set; }
            public string Classteacher { get; set; }
        }
    }
