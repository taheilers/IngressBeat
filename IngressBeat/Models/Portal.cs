using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IngressBeat.Models
{
    public class Portal
    {
        //Primary Key
        public int ID { get; set; }
        public string PortalName { get; set; }
        public float PLat { get; set; }
        public float PLong { get; set; }
        public int Faction { get; set; }
        [ForeignKey("Faction")]
        public virtual Faction Owner { get; set; }
    }
}