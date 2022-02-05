using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class TbItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; }
        public decimal? SalesPrice { get; set; }
        public string ImageName { get; set; }
        public string Disciption { get; set; }
        public int? CategoryId { get; set; }

        public virtual TbCategory Category { get; set; }
    }
}
