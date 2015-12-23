using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailORder.Models
{
    public class OnlineRetailOrderContext:DbContext
    {
        public DbSet<_Online_Retail_HDR> _Online_Retail_HDRs { get; set; }
        public DbSet<_Online_Retail_DTL> _Online_Retail_DTLs { get; set; }
        
    }
}
