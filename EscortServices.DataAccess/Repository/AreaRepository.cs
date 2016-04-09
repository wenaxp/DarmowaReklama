using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public class AreaRepository
    {
        private readonly EscortServicesEntities _context;

        public AreaRepository(EscortServicesEntities context)
        {
            _context = context;
        }

        public IQueryable<GetDistrictByCityId_Result> GetDistrictByCityId(string cityId)
        {
            var res= _context.GetDistrictByCityId(cityId);
            return res.AsQueryable<GetDistrictByCityId_Result>();
        }

        public IQueryable<SearchCityByName_Result> SearchCityByName(string name)
        {
            var res = _context.SearchCityByName(name);
            return res.AsQueryable<SearchCityByName_Result>();
        }

    }
}
