using KlassyCafe.NewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Bl
{
    public interface IJopsService
        {
        public List<TbJop> GetAll();
        public TbJop GetById(int id);
        public bool Add(TbJop jop);
        public bool Delete(int id);
        }
    public class ClsJops : IJopsService
    {
        KlassyCafeContext ctx;
        public ClsJops(KlassyCafeContext context)
        {
            ctx = context;
        }

        public List<TbJop> GetAll()
        {
            List<TbJop> Jops = ctx.TbJops.ToList();
            return Jops;
        }

        public TbJop GetById(int id)
        {
            try
            {
                TbJop Jop = ctx.TbJops.Where(a=>a.Id==id).FirstOrDefault();
                return Jop;
            }
            catch(Exception ex)
            {
                return new TbJop() ;
            }

        }

        public bool Add(TbJop jop)
        {
            try
            {
                ctx.TbJops.Add(jop);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        public bool Delete(int id)
        {
            try
            {
                TbJop RemJop = ctx.TbJops.Where(a => a.Id == id).FirstOrDefault();
                ctx.TbJops.Remove(RemJop);
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
