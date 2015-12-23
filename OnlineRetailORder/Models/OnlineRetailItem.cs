using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailORder.Models
{
    [Table("_Online_Retail_DTL")]
    public class _Online_Retail_DTL
    {
        
        // public int id { get; set; }
        [Key]
        public long odItem_id { get; set; }

        [ForeignKey("_Online_Retail_HDR")]
        public long od_id  { get; set; }
        public string skuno { get; set; }
        public string description { get; set; }
        public int od_qty { get; set; }
        public double od_price { get; set; }
        public double od_item_discount { get; set; }
        
        public virtual _Online_Retail_HDR _Online_Retail_HDR  { get; set; }

        
    }
}
