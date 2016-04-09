using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public class AdvertisementRepository
    {
        private readonly EscortServicesEntities _context;
        public AdvertisementRepository(EscortServicesEntities context)
        {
            _context = context;
        }

        public Advertisement Get(string publicId)
        {
            var res = _context.Advertisement.Single(x => x.PublicId == publicId);
            return res;
        }

        public void Save(Advertisement advertisement)
        {
            if (advertisement.Id==0)
                _context.Advertisement.Add(advertisement);
            else
                _context.Advertisement.Attach(advertisement);
            _context.SaveChanges();
        }

        //public Queryable<Advertisement> GetList()
        //{
        //    _context.
        //}
    }
}
