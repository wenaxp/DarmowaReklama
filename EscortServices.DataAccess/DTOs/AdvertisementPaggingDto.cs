using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.DTOs
{
    public class AdvertisementPaggingDto
    {
        public AdvertisementPaggingDto(int pageNo, int pageSize, string sortColumn, string sortOrder)
        {
            if (string.IsNullOrEmpty(sortColumn))
                throw new ArgumentNullException("sortColumn");
            if (string.IsNullOrEmpty(sortOrder))
                throw new ArgumentNullException("sortOrder");

            this.pageNo = pageNo;
            this.pageSize = pageSize;
            this.sortColumn = sortColumn;
            this.sortOrder = sortOrder;
        }

        public int pageNo { get; private set; }
        public int pageSize { get; private set; }
        public string sortColumn { get; private set; }
        public string sortOrder { get; private set; }

        public int? cityId { get; set; }
        public int? voivodeshipId { get; set; }
        public int? ageFrom { get; set; }
        public int? ageTo { get; set; }
        public int? weightFrom { get; set; }
        public int? weightTo { get; set; }
        public int? bustSizeFrom { get; set; }
        public int? bustSizeTo { get; set; }
        public bool? english { get; set; }
        public bool? german { get; set; }
        public bool? russian { get; set; }
        public int? price1hFrom { get; set; }
        public int? price1hTo { get; set; }
        public int? price30minFrom { get; set; }
        public int? price30minTo { get; set; }
        public int? price15minFrom { get; set; }
        public int? price15minTo { get; set; }
        public int? priceAllNightFrom { get; set; }
        public int? priceAllNightTo { get; set; }
        public int? outCallsId { get; set; }
    }
}
