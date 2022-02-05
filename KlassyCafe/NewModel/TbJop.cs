using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class TbJop
    {
        public TbJop()
        {
            TbEmployees = new HashSet<TbEmployee>();
        }

        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<TbEmployee> TbEmployees { get; set; }
    }
}
