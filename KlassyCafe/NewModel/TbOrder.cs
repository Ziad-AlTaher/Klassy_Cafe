using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class TbOrder
    {
        public int OrderId { get; set; }
        public DateTime? DateTimeNow { get; set; }
        public string CustomerName { get; set; }
        public string Address { get; set; }
        public DateTime? DeleveryDateTime { get; set; }
        public bool? Delevered { get; set; }
        public bool? Canceled { get; set; }
    }
}
