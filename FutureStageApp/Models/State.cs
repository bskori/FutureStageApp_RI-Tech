using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace FutureStageApp.Models
{
    [Table("StateTbl")]
    public class State
    {
        [Key]
        public Int64 StateID { get; set; }
        public string StateName { get; set; }
        public virtual List<City> Cities { get; set; }
    }
}
