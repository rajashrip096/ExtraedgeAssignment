using ExtraedgeAssignment.Models;
using ExtraedgeAssignment.Respositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Services
{
    public class MobileBrandService:IMobileBrandService
    {
        private readonly IMobileBrandRepository _iMobileBrandRepo;
        public MobileBrandService(IMobileBrandRepository iMobileBrandRepo)
        {
            _iMobileBrandRepo = iMobileBrandRepo;
        }
        public int AddMobileBrand(MobileBrand mobilebrand)
        {
            return _iMobileBrandRepo.AddMobileBrand(mobilebrand);
        }
        public int DeleteMobileBrand(int id)
        {
            return _iMobileBrandRepo.DeleteMobileBrand(id);
        }
        public IEnumerable<MobileBrand> GetAllMobileBrand()
        {
            return _iMobileBrandRepo.GetAllMobileBrand();
        }
        public int ModifyMobileBrand(MobileBrand mobilebrand)
        {
            return _iMobileBrandRepo.ModifyMobileBrand(mobilebrand);
        }
    }
}
