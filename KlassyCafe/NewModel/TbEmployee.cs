using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class TbEmployee
    {
        public int NationalId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public int? JopId { get; set; }
        public string Cockes { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Insta { get; set; }
        public string ImageName { get; set; }

        public virtual TbJop Jop { get; set; }
    }
}
