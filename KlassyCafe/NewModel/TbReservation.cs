using System;
using System.Collections.Generic;

#nullable disable

namespace KlassyCafe.NewModel
{
    public partial class TbReservation
    {
        public int ReservationId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int? NGuests { get; set; }
        public string Message { get; set; }
        public DateTime? TimeSent { get; set; }
    }
}
