using KlassyCafe.NewModel;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KlassyCafe.Models
{
    public interface IitemService
    {
        public List<TbItem> GetAll();
        public List<VwItemCategory> GetAllItemsWithCats();
        public TbItem GetById(int ItemId);
        public bool Add(TbItem item);
        public bool Edit(TbItem item);
        public bool Delete(int id);
    }
    public class ClsItems:IitemService
    {
        KlassyCafeContext ctx;
        public ClsItems(KlassyCafeContext context)
        {
            ctx=context;
        }

        public List<TbItem> GetAll()
        {
            List<TbItem> LstItems = ctx.TbItems.Include(a => a.Category).ToList();
            return LstItems;
        }
        public List<VwItemCategory> GetAllItemsWithCats()
        {
            List<VwItemCategory> LstItemCat = ctx.VwItemCategories.ToList();
            return LstItemCat;
        }

        public TbItem GetById(int ItemId)
        {
            try
            {
                TbItem item = ctx.TbItems.Where(a => a.ItemId == ItemId).FirstOrDefault();
                return item;
            }
            catch
            {
                // 1st record if it false to reach the data base null null null up to all we can send error page 
                return new TbItem();
            }

        }
        // we want to make a related items table M to M relation 
        //public TbItem GetByIdWithImage(int ItemId)
        //{
            
        //    return new TbItem();
        //}
        public bool Add(TbItem item)
        {
            //try
            //{
            //    SqlConnection con = new SqlConnection();
            //    con.ConnectionString = "Server=DESKTOP-9UFN9IR\\SQLEXPRESS;Database=KlassyCafe;Trusted_Connection=True;";

            //    string query1 = "insert into TbItems(ItemId,ItemName,SalesPrice,ImageName,Disciption,CategoryId) values ("
            //        + item.ItemId + "," + item.ItemName + "," + item.SalesPrice + "," + item.ImageName + "," + item.Disciption + "," + item.CategoryId + ")";



            //    SqlCommand cmd1 = new SqlCommand(query1, con);
            //    con.Open();
            //    cmd1.ExecuteNonQuery();
            //    con.Close();

            //    return true;
            //}
            //catch(Exception ex)
            //{
            //    return false;
            //}


            try
            {
                item.ItemId = item.ItemId + 1;
                ctx.Add<TbItem>(item);
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
        public bool Edit(TbItem item)
        {
            try
            {
                ctx.Entry(item).State = EntityState.Modified;
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
                ctx.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }
    }
}
