using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class VwInvDatum
    {
        public int OrderId { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DateTime? DeleveryDateTime { get; set; }
        public double Qty { get; set; }
        public decimal InvoicePrice { get; set; }
        public string CategoryName { get; set; }
        public string ItemName { get; set; }
        public decimal? SalesPrice { get; set; }
    }
}
