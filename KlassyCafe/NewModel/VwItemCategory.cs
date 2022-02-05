using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class VwItemCategory
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? SalesPrice { get; set; }
        public string ImageName { get; set; }
        public string Disciption { get; set; }
    }
}
