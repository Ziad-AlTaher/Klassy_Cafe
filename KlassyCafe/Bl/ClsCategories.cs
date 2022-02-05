using KlassyCafe.NewModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Models
{
    public interface ICategoryService
    {
        public List<TbCategory> GetAll();
        public TbCategory GetById(int CatId);
        public bool Add(TbCategory category);
        public bool Edit(TbCategory category);
        public bool Delete(int id);
    }
    public class ClsCategories: ICategoryService
    {
        KlassyCafeContext ctx;
        public ClsCategories(KlassyCafeContext context)
        {
            ctx = context;
        }

        public List<TbCategory> GetAll()
        {
            List<TbCategory> LstItems = ctx.TbCategories.ToList();
            return LstItems;
        }
       

        public TbCategory GetById(int CatId)
        {
            try
            {
                TbCategory Cat = ctx.TbCategories.Where(a => a.CategoryId == CatId).FirstOrDefault();
                return Cat;
            }
            catch
            {
                // 1st record if it false to reach the data base null null null up to all we can send error page 
                return new TbCategory();
            }

        }
        // we want to make a related items table M to M relation 
        //public TbItem GetByIdWithImage(int ItemId)
        //{

        //    return new TbItem();
        //}
        public bool Add(TbCategory category)
        {
            try
            {
                ctx.Add<TbCategory>(category);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Edit(TbCategory category)
        {
            try
            {
                ctx.Entry(category).State = EntityState.Modified;
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
                TbItem DelItems = ctx.TbItems.Where(a => a.ItemId == id).FirstOrDefault();
                ctx.TbItems.Remove(DelItems);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
