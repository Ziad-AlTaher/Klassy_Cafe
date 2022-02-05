using KlassyCafe.NewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Models
{
    public class HomeModel
    {
        public IEnumerable<TbSlider> LstSlider { get; set; }
        public IEnumerable<TbItem> LstItems { get; set; }
        public IEnumerable<TbEmployee> LstCheffs { get; set; }
        public IEnumerable<TbCategory> LstCategories { get; set; }
        public TbReservation NewReservatio { get; set; }
    }
}
