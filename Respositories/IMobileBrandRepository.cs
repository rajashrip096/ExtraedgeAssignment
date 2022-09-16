using ExtraedgeAssignment.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExtraedgeAssignment.Respositories
{
    public interface IMobileBrandRepository
    {
        IEnumerable<MobileBrand> GetAllMobileBrand();
        int AddMobileBrand(MobileBrand mobilebrand);
        int ModifyMobileBrand(MobileBrand mobilebrand);
        int DeleteMobileBrand(int id);
    }
}
