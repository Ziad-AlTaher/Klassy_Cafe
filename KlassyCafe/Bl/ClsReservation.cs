using KlassyCafe.NewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Bl
{
    public interface IReservationService
    {
        public bool Add(TbReservation reservation);
        public bool Delete(int ReserveId, string ResDate);
        public List<TbReservation> GetAll();
    }
    public class ClsReservation :IReservationService
    {
        KlassyCafeContext ctx;
        public ClsReservation(KlassyCafeContext context)
        {
            ctx = context;

        }
        public bool Add(TbReservation reservation)
        {
            try
            {
                reservation.Date = Convert.ToString(reservation.Date);
                List<TbReservation> dateReservation = ctx.TbReservations.Where(a =>a.Date == reservation.Date).ToList();
                if (dateReservation.Count() > 0) { reservation.ReservationId = dateReservation.Count(); }
                else reservation.ReservationId = 0;
                ctx.TbReservations.Add(reservation);
                ctx.SaveChanges();
                return true;
            }
            catch(Exception ex)
            {

                return false;
            }
        }

        public bool Delete(int ReserveId, string ResDate)
        {
            try
            {
                //ResDate = Convert.ToDateTime(ResDate);
                List<TbReservation> dateReservation = ctx.TbReservations.Where(a => a.ReservationId == ReserveId).ToList();
                TbReservation delReservation = dateReservation.Where(a => a.Date == ResDate).FirstOrDefault();
                ctx.TbReservations.Remove(delReservation);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {

                return false;
            }
        }

        public List<TbReservation> GetAll()
        {
            List<TbReservation> lstReservation = ctx.TbReservations.ToList();

            return lstReservation;
        }
    }
}
