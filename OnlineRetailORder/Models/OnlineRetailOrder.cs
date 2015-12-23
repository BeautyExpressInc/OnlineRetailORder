using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineRetailORder.Models
{
    
    public class _Online_Retail_HDR
    {
        public _Online_Retail_HDR()
        {
            OnlineRetailItems = new List<_Online_Retail_DTL>();
        }

        //public int id { get; set; }
        // [Column("od_id")]
        [Key]
        public long od_id { get; set; }
        public string od_OrderSource { get; set; }
        public string od_date { get; set; }
        public string od_status { get; set; }
        public string od_shipping_last_name { get; set; }
        public string od_shipping_email { get; set; }
        public string ShippingDate { get; set; }
        public string ShippedBy { get; set; }
        public double total_discounts { get; set; }
        public double subtotal_price { get; set; }
        public double total_price { get; set; }
        public string discount_code { get; set; }
        public string discount_type { get; set; }
        public double discount_amount { get; set; }
        
        

        //[ForeignKey("od_id")]
        //public _Online_Retail_DTL _Online_Retail_DTL { get; set; }

        public virtual ICollection<_Online_Retail_DTL> OnlineRetailItems { get; set; }
    }
}
