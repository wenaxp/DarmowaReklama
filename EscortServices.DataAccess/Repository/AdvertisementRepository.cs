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
    public class AdvertisementRepository : BaseRepository, IAdvertisementRepository
    {
        private readonly IParameterRepository _parameterRepository;

        public AdvertisementRepository(EscortServicesEntities context, IParameterRepository parameterRepository)
            : base(context)
        {
            _parameterRepository = parameterRepository;
        }

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

        public AdvertisementPaggingDto GetAdvertisementPagging(AdvertisementPaggingDto advPagging)
        {
            advPagging = advPagging ?? new AdvertisementPaggingDto();

            FillPagging(advPagging);

            FillListAndTotalPages(advPagging);

            return advPagging;
        }

        private void FillPagging(AdvertisementPaggingDto advPagging)
        {
            advPagging.PageNo = advPagging.PageNo ?? 1;
            advPagging.PageSize = advPagging.PageSize ?? _parameterRepository.GetInt(ParameterNameEnum.AdvertisementPageSize);
            advPagging.SortColumn = advPagging.SortColumn ?? "Date";
            advPagging.IsAsc = advPagging.IsAsc ?? false;
        }

        private void FillListAndTotalPages(AdvertisementPaggingDto advPagging)
        {
            var totalPagesOp = new ObjectParameter("TotalPages", typeof(int));

            var list = _context.AdvertisementPagging(totalPagesOp, advPagging.PageNo, advPagging.PageSize, advPagging.SortColumn,
                advPagging.IsAsc, advPagging.CategoryId, advPagging.CityId, advPagging.VoivodeshipId, advPagging.AgeFrom, advPagging.AgeTo,
                advPagging.WeightFrom, advPagging.WeightTo, advPagging.HeightFrom, advPagging.HeightTo, advPagging.BreastSizeFrom,
                advPagging.BreastSizeTo, advPagging.IsEnglish, advPagging.IsGerman, advPagging.IsRussian, advPagging.Price1hFrom,
                advPagging.Price1hTo, advPagging.Price30minFrom, advPagging.Price30minTo, advPagging.Price15minFrom, advPagging.Price15minTo,
                advPagging.PriceAllNightFrom, advPagging.PriceAllNightTo, advPagging.OutCallsId);
            advPagging.List = list.ToList();
            advPagging.TotalPages = (int)(totalPagesOp.Value ?? 0);
        }
    }
}
