using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace DecisionIT.Models
{
    public class DecisionITContext : DbContext
    {
        // 
        public DecisionITContext() : base("name=DecisionITContext")
        {
        }

        public System.Data.Entity.DbSet<DecisionIT.Models.Participante> Participantes { get; set; }
        }
}
