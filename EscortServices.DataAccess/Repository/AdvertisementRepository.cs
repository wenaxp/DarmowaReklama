using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.Core.Objects;
using EscortServices.DataAccess.DTOs;
using System.IO;

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

        public List<Advertisement> GetList(out int totalPages, AdvertisementPaggingDto parameters)
        {
            var totalPagesOp = new ObjectParameter("TotalPages", typeof(int));


            using (var sqlLogFile = new StreamWriter(@"C:\Users\pko-darek\Desktop\sqlLogFile.txt"))
            {
                _context.Database.Log = sqlLogFile.Write;

                var query1 = _context.AdvertisementPagging(totalPagesOp, parameters.PageNo, parameters.PageSize, parameters.SortColumn,
              parameters.SortOrder, parameters.CityId, parameters.VoivodeshipId, parameters.AgeFrom, parameters.AgeTo,
              parameters.WeightFrom, parameters.WeightTo, parameters.BustSizeFrom, parameters.BustSizeTo, parameters.English,
              parameters.German, parameters.Russian, parameters.Price1hFrom, parameters.Price1hTo, parameters.Price30minFrom,
              parameters.Price30minTo, parameters.Price15minFrom, parameters.Price15minTo, parameters.PriceAllNightFrom,
              parameters.PriceAllNightTo, parameters.OutCallsId).ToList();
                _context.SaveChanges();
            }

            var query =_context.AdvertisementPagging(totalPagesOp, parameters.PageNo, parameters.PageSize, parameters.SortColumn, 
                parameters.SortOrder, parameters.CityId, parameters.VoivodeshipId, parameters.AgeFrom, parameters.AgeTo, 
                parameters.WeightFrom, parameters.WeightTo, parameters.BustSizeFrom, parameters.BustSizeTo, parameters.English,
                parameters.German, parameters.Russian, parameters.Price1hFrom, parameters.Price1hTo, parameters.Price30minFrom, 
                parameters.Price30minTo, parameters.Price15minFrom, parameters.Price15minTo, parameters.PriceAllNightFrom,
                parameters.PriceAllNightTo, parameters.OutCallsId).AsQueryable();
            var sql = ((System.Data.Entity.Core.Objects.ObjectQuery)query).ToTraceString();
            var res= query.ToList();
            totalPages = (int)totalPagesOp.Value;

            return res;


        }
    }
}
