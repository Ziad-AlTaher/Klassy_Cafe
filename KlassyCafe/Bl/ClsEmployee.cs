using KlassyCafe.NewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Bl
{
    public interface IEmployeeServic
    {
        public List<TbEmployee> GetAll();
        public TbEmployee GetById(int NatId);
        public bool Add(TbEmployee Emp);
        public Task<TbEmployee> Edit(TbEmployee Emp);
        public bool Delete(int NatId);
        public List<TbEmployee> GetAllCheffs();
    }
    public class ClsEmployee : IEmployeeServic
    {
        KlassyCafeContext ctx;
        public ClsEmployee(KlassyCafeContext context)
        {
            ctx  = context;
        }
        public List<TbEmployee> GetAll()
        {
            List<TbEmployee> LstEmployee = ctx.TbEmployees.Include(a => a.Jop).ToList();
            return LstEmployee;
        }
        public List<TbEmployee> GetAllCheffs ()
        {
            //we want to filter it according to jopId 
            List<TbEmployee> LstEmployee = ctx.TbEmployees.Where(a => a.JopId == 1).ToList();
            return LstEmployee;
        }
        public TbEmployee GetById(int NatId)
        {
            TbEmployee Emp = ctx.TbEmployees.FirstOrDefault(a => a.NationalId == NatId);
            return Emp;
        }
        public bool Add(TbEmployee Emp)
        {
            try
            {
                ctx.Add<TbEmployee>(Emp);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public async Task<TbEmployee> Edit(TbEmployee Emp)
        {
            try
            {
                using (var db = new KlassyCafeContext())
                {
                    db.TbEmployees.Update(Emp);
                    int affected = await db.SaveChangesAsync();
                    if (affected == 1)
                    {
                        return Emp;
                    }
                    return null;
                }
            }
            catch
            {
                return null;
            }
        }
        //public  bool Edit(TbEmployee Emp)
        //{
            
        //    try
        //    {
        //        ctx.Entry(Emp).State = EntityState.Detached;
        //        ctx.Entry(Emp).State = EntityState.Modified;
        //        ctx.SaveChanges();
        //        return true;
        //    }
        //    catch (Exception ex)
        //    {
        //        return false;
        //    }



        //}
        public bool Delete(int NatId)
        {
            try
            {
                TbEmployee DelItems = ctx.TbEmployees.Where(a => a.NationalId == NatId).FirstOrDefault();
                ctx.TbEmployees.Remove(DelItems);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
