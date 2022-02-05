using KlassyCafe.NewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Bl
{
    public interface ISliderService
    {
        public List<TbSlider> GetAll();
        public bool Add(TbSlider slider);
        public bool Delete(int SlideId);
    }
    public class ClsSlider : ISliderService
    {
        KlassyCafeContext ctx;
        public ClsSlider(KlassyCafeContext context)
        {
            ctx = context;
        }
        
        public List<TbSlider> GetAll()
        {
            List<TbSlider> Slider = ctx.TbSliders.ToList();
            return Slider;
        }

        public bool Add(TbSlider slider)
        {
            try
            {
                ctx.TbSliders.Add(slider);
                ctx.SaveChanges();
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
        }
        public bool Delete(int SlideId)
        {
            try
            {
                TbSlider RemSlide = ctx.TbSliders.Where(a => a.SliderId == SlideId).FirstOrDefault();
                ctx.TbSliders.Remove(RemSlide);
                ctx.SaveChanges();
                return true;

            }
            catch(Exception ex)
            {
                return false;
            }
        }
    }
}
