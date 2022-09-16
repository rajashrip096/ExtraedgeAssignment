using ExtraedgeAssignment.Entities;
using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Respositories
{
    public class MobileBrandRepository: IMobileBrandRepository
    {
        ApplicationDbContext context;
        public MobileBrandRepository(ApplicationDbContext context) //DI
        {
            this.context = context;
        }

        public int AddMobileBrand(MobileBrand mobilebrand)
        {
            context.MobileBrand.Add(mobilebrand);
            context.SaveChanges(); // update the data in DB
            return 1;
        }

        public int DeleteMobileBrand(int id)
        {
            var mobilebrand = context.MobileBrand.Where(p => p.Id == id).SingleOrDefault();
            if (mobilebrand != null)
            {
                context.MobileBrand.Remove(mobilebrand);
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public IEnumerable<MobileBrand> GetAllMobileBrand()
        {
            return context.MobileBrand.ToList();
        }

        public int ModifyMobileBrand(MobileBrand mb)
        {
           
            var mobilebrand = context.MobileBrand.Where(p => p.Id == mb.Id).SingleOrDefault();
            if (mobilebrand != null)
            {
                mobilebrand.BrandName = mobilebrand.BrandName;
                mobilebrand.Price = mobilebrand.Price;
                context.SaveChanges();
                return 1;
            }
            else
            {
                return 0;
            }

        }
    }
}
