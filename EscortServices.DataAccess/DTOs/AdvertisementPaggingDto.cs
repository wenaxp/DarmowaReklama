using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.DTOs
{
    public class AdvertisementPaggingDto
    {
        public int? TotalPages { get; set; }
        public int? PageNo { get; set; }
        public int? PageSize { get; set; }
        public string SortColumn { get; set; }
        public bool? IsAsc { get; set; }
        public int? CategoryId { get; set; }
        public int? CityId { get; set; }
        public int? VoivodeshipId { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public int? WeightFrom { get; set; }
        public int? WeightTo { get; set; }
        public int? HeightFrom { get; set; }
        public int? HeightTo { get; set; }
        public int? BreastSizeFrom { get; set; }
        public int? BreastSizeTo { get; set; }
        public bool? IsEnglish { get; set; }
        public bool? IsGerman { get; set; }
        public bool? IsRussian { get; set; }
        public int? Price1hFrom { get; set; }
        public int? Price1hTo { get; set; }
        public int? Price30minFrom { get; set; }
        public int? Price30minTo { get; set; }
        public int? Price15minFrom { get; set; }
        public int? Price15minTo { get; set; }
        public int? PriceAllNightFrom { get; set; }
        public int? PriceAllNightTo { get; set; }
        public int? OutCallsId { get; set; }
        public IEnumerable<Advertisement> List { get; set; }
    }
}
