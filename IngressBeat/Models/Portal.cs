using System;
using System.Collections.Generic;
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
        public bool Captured { get; set; }
        public bool Faction { get; set; }
    }
}