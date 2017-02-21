using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace IngressBeat.Models
{
    public class Faction
    {
        public int ID { get; set; }
        public string FactionName { get; set; }
    }
}