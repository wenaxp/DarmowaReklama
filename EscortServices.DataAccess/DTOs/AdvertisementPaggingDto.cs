using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.DTOs
{
    public class AdvertisementPaggingDto
    {
        public int? PageNo { get; private set; }
        public int? PageSize { get; private set; }
        public string SortColumn { get; private set; }
        public string SortOrder { get; private set; }

        public int? CityId { get; set; }
        public int? VoivodeshipId { get; set; }
        public int? AgeFrom { get; set; }
        public int? AgeTo { get; set; }
        public int? WeightFrom { get; set; }
        public int? WeightTo { get; set; }
        public int? BustSizeFrom { get; set; }
        public int? BustSizeTo { get; set; }
        public bool? English { get; set; }
        public bool? German { get; set; }
        public bool? Russian { get; set; }
        public int? Price1hFrom { get; set; }
        public int? Price1hTo { get; set; }
        public int? Price30minFrom { get; set; }
        public int? Price30minTo { get; set; }
        public int? Price15minFrom { get; set; }
        public int? Price15minTo { get; set; }
        public int? PriceAllNightFrom { get; set; }
        public int? PriceAllNightTo { get; set; }
        public int? OutCallsId { get; set; }
    }
}
