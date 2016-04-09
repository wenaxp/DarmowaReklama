using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using EscortServices.DataAccess.DTOs;

namespace EscortServices.DataAccess.Repository
{
    public class AdvertisementRepository: BaseRepository, IAdvertisementRepository
    {
        public AdvertisementRepository(EscortServicesEntities context)
            :base(context)
        {}
        public Advertisement Get(string publicId)
        {
            var res = _context.Advertisement.Single(x => x.PublicId == publicId);
            return res;
        }

        public void Save(Advertisement advertisement)
        {
            if (advertisement.Id == 0)
                _context.Advertisement.Add(advertisement);
            else
                _context.Advertisement.Attach(advertisement);
            _context.SaveChanges();
        }

        public IQueryable<Advertisement> GetList(out int totalPages, AdvertisementPaggingDto parameters)
        {
            var totalPagesOp = new ObjectParameter("TotalPages", typeof(int));

            var res =_context.AdvertisementPagging(totalPagesOp, parameters.pageNo, parameters.pageSize, parameters.sortColumn, 
                parameters.sortOrder, parameters.cityId, parameters.voivodeshipId, parameters.ageFrom, parameters.ageTo, 
                parameters.weightFrom, parameters.weightTo, parameters.bustSizeFrom, parameters.bustSizeTo, parameters.english,
                parameters.german, parameters.russian, parameters.price1hFrom, parameters.price1hTo, parameters.price30minFrom, 
                parameters.price30minTo, parameters.price15minFrom, parameters.price15minTo, parameters.priceAllNightFrom,
                parameters.priceAllNightTo, parameters.outCallsId).AsQueryable();

            totalPages = (int)totalPagesOp.Value;

            return res;
        }
    }
}
