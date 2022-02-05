using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class TbInvoice
    {
        public int ItemId { get; set; }
        public int InvoiceId { get; set; }
        public double Qty { get; set; }
        public decimal InvoicePrice { get; set; }
        public string Notes { get; set; }

        public virtual TbOrder Invoice { get; set; }
        public virtual TbItem Item { get; set; }
    }
}
