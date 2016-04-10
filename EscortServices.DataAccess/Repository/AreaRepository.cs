using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public class AreaRepository : BaseRepository
    {
        public AreaRepository(EscortServicesEntities context) 
            : base(context)
        { }

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
