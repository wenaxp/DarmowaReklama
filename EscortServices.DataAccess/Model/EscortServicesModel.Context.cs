﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace EscortServices.DataAccess.Model
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class EscortServicesEntities : DbContext
    {
        public EscortServicesEntities()
            : base("name=EscortServicesEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Parameter> Parameter { get; set; }
        public virtual DbSet<Advertisement> Advertisement { get; set; }
    
        public virtual ObjectResult<GetDistrictByCityId_Result> GetDistrictByCityId(string cityId)
        {
            var cityIdParameter = cityId != null ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<GetDistrictByCityId_Result>("GetDistrictByCityId", cityIdParameter);
        }
    
        public virtual ObjectResult<SearchCityByName_Result> SearchCityByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<SearchCityByName_Result>("SearchCityByName", nameParameter);
        }
    
        public virtual ObjectResult<Advertisement> AdvertisementPagging(ObjectParameter totalPages, Nullable<int> pageNo, Nullable<int> pageSize, string sortColumn, Nullable<bool> isAsc, Nullable<int> cityId, Nullable<int> voivodeshipId, Nullable<int> ageFrom, Nullable<int> ageTo, Nullable<int> weightFrom, Nullable<int> weightTo, Nullable<int> bustSizeFrom, Nullable<int> bustSizeTo, Nullable<bool> isEnglish, Nullable<bool> isGerman, Nullable<bool> isRussian, Nullable<int> price1hFrom, Nullable<int> price1hTo, Nullable<int> price30minFrom, Nullable<int> price30minTo, Nullable<int> price15minFrom, Nullable<int> price15minTo, Nullable<int> priceAllNightFrom, Nullable<int> priceAllNightTo, Nullable<int> outCallsId)
        {
            var pageNoParameter = pageNo.HasValue ?
                new ObjectParameter("PageNo", pageNo) :
                new ObjectParameter("PageNo", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            var sortColumnParameter = sortColumn != null ?
                new ObjectParameter("SortColumn", sortColumn) :
                new ObjectParameter("SortColumn", typeof(string));
    
            var isAscParameter = isAsc.HasValue ?
                new ObjectParameter("IsAsc", isAsc) :
                new ObjectParameter("IsAsc", typeof(bool));
    
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var voivodeshipIdParameter = voivodeshipId.HasValue ?
                new ObjectParameter("VoivodeshipId", voivodeshipId) :
                new ObjectParameter("VoivodeshipId", typeof(int));
    
            var ageFromParameter = ageFrom.HasValue ?
                new ObjectParameter("AgeFrom", ageFrom) :
                new ObjectParameter("AgeFrom", typeof(int));
    
            var ageToParameter = ageTo.HasValue ?
                new ObjectParameter("AgeTo", ageTo) :
                new ObjectParameter("AgeTo", typeof(int));
    
            var weightFromParameter = weightFrom.HasValue ?
                new ObjectParameter("WeightFrom", weightFrom) :
                new ObjectParameter("WeightFrom", typeof(int));
    
            var weightToParameter = weightTo.HasValue ?
                new ObjectParameter("WeightTo", weightTo) :
                new ObjectParameter("WeightTo", typeof(int));
    
            var bustSizeFromParameter = bustSizeFrom.HasValue ?
                new ObjectParameter("BustSizeFrom", bustSizeFrom) :
                new ObjectParameter("BustSizeFrom", typeof(int));
    
            var bustSizeToParameter = bustSizeTo.HasValue ?
                new ObjectParameter("BustSizeTo", bustSizeTo) :
                new ObjectParameter("BustSizeTo", typeof(int));
    
            var isEnglishParameter = isEnglish.HasValue ?
                new ObjectParameter("IsEnglish", isEnglish) :
                new ObjectParameter("IsEnglish", typeof(bool));
    
            var isGermanParameter = isGerman.HasValue ?
                new ObjectParameter("IsGerman", isGerman) :
                new ObjectParameter("IsGerman", typeof(bool));
    
            var isRussianParameter = isRussian.HasValue ?
                new ObjectParameter("IsRussian", isRussian) :
                new ObjectParameter("IsRussian", typeof(bool));
    
            var price1hFromParameter = price1hFrom.HasValue ?
                new ObjectParameter("Price1hFrom", price1hFrom) :
                new ObjectParameter("Price1hFrom", typeof(int));
    
            var price1hToParameter = price1hTo.HasValue ?
                new ObjectParameter("Price1hTo", price1hTo) :
                new ObjectParameter("Price1hTo", typeof(int));
    
            var price30minFromParameter = price30minFrom.HasValue ?
                new ObjectParameter("Price30minFrom", price30minFrom) :
                new ObjectParameter("Price30minFrom", typeof(int));
    
            var price30minToParameter = price30minTo.HasValue ?
                new ObjectParameter("Price30minTo", price30minTo) :
                new ObjectParameter("Price30minTo", typeof(int));
    
            var price15minFromParameter = price15minFrom.HasValue ?
                new ObjectParameter("Price15minFrom", price15minFrom) :
                new ObjectParameter("Price15minFrom", typeof(int));
    
            var price15minToParameter = price15minTo.HasValue ?
                new ObjectParameter("Price15minTo", price15minTo) :
                new ObjectParameter("Price15minTo", typeof(int));
    
            var priceAllNightFromParameter = priceAllNightFrom.HasValue ?
                new ObjectParameter("PriceAllNightFrom", priceAllNightFrom) :
                new ObjectParameter("PriceAllNightFrom", typeof(int));
    
            var priceAllNightToParameter = priceAllNightTo.HasValue ?
                new ObjectParameter("PriceAllNightTo", priceAllNightTo) :
                new ObjectParameter("PriceAllNightTo", typeof(int));
    
            var outCallsIdParameter = outCallsId.HasValue ?
                new ObjectParameter("OutCallsId", outCallsId) :
                new ObjectParameter("OutCallsId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Advertisement>("AdvertisementPagging", totalPages, pageNoParameter, pageSizeParameter, sortColumnParameter, isAscParameter, cityIdParameter, voivodeshipIdParameter, ageFromParameter, ageToParameter, weightFromParameter, weightToParameter, bustSizeFromParameter, bustSizeToParameter, isEnglishParameter, isGermanParameter, isRussianParameter, price1hFromParameter, price1hToParameter, price30minFromParameter, price30minToParameter, price15minFromParameter, price15minToParameter, priceAllNightFromParameter, priceAllNightToParameter, outCallsIdParameter);
        }
    
        public virtual ObjectResult<Advertisement> AdvertisementPagging(ObjectParameter totalPages, Nullable<int> pageNo, Nullable<int> pageSize, string sortColumn, Nullable<bool> isAsc, Nullable<int> cityId, Nullable<int> voivodeshipId, Nullable<int> ageFrom, Nullable<int> ageTo, Nullable<int> weightFrom, Nullable<int> weightTo, Nullable<int> bustSizeFrom, Nullable<int> bustSizeTo, Nullable<bool> isEnglish, Nullable<bool> isGerman, Nullable<bool> isRussian, Nullable<int> price1hFrom, Nullable<int> price1hTo, Nullable<int> price30minFrom, Nullable<int> price30minTo, Nullable<int> price15minFrom, Nullable<int> price15minTo, Nullable<int> priceAllNightFrom, Nullable<int> priceAllNightTo, Nullable<int> outCallsId, MergeOption mergeOption)
        {
            var pageNoParameter = pageNo.HasValue ?
                new ObjectParameter("PageNo", pageNo) :
                new ObjectParameter("PageNo", typeof(int));
    
            var pageSizeParameter = pageSize.HasValue ?
                new ObjectParameter("PageSize", pageSize) :
                new ObjectParameter("PageSize", typeof(int));
    
            var sortColumnParameter = sortColumn != null ?
                new ObjectParameter("SortColumn", sortColumn) :
                new ObjectParameter("SortColumn", typeof(string));
    
            var isAscParameter = isAsc.HasValue ?
                new ObjectParameter("IsAsc", isAsc) :
                new ObjectParameter("IsAsc", typeof(bool));
    
            var cityIdParameter = cityId.HasValue ?
                new ObjectParameter("CityId", cityId) :
                new ObjectParameter("CityId", typeof(int));
    
            var voivodeshipIdParameter = voivodeshipId.HasValue ?
                new ObjectParameter("VoivodeshipId", voivodeshipId) :
                new ObjectParameter("VoivodeshipId", typeof(int));
    
            var ageFromParameter = ageFrom.HasValue ?
                new ObjectParameter("AgeFrom", ageFrom) :
                new ObjectParameter("AgeFrom", typeof(int));
    
            var ageToParameter = ageTo.HasValue ?
                new ObjectParameter("AgeTo", ageTo) :
                new ObjectParameter("AgeTo", typeof(int));
    
            var weightFromParameter = weightFrom.HasValue ?
                new ObjectParameter("WeightFrom", weightFrom) :
                new ObjectParameter("WeightFrom", typeof(int));
    
            var weightToParameter = weightTo.HasValue ?
                new ObjectParameter("WeightTo", weightTo) :
                new ObjectParameter("WeightTo", typeof(int));
    
            var bustSizeFromParameter = bustSizeFrom.HasValue ?
                new ObjectParameter("BustSizeFrom", bustSizeFrom) :
                new ObjectParameter("BustSizeFrom", typeof(int));
    
            var bustSizeToParameter = bustSizeTo.HasValue ?
                new ObjectParameter("BustSizeTo", bustSizeTo) :
                new ObjectParameter("BustSizeTo", typeof(int));
    
            var isEnglishParameter = isEnglish.HasValue ?
                new ObjectParameter("IsEnglish", isEnglish) :
                new ObjectParameter("IsEnglish", typeof(bool));
    
            var isGermanParameter = isGerman.HasValue ?
                new ObjectParameter("IsGerman", isGerman) :
                new ObjectParameter("IsGerman", typeof(bool));
    
            var isRussianParameter = isRussian.HasValue ?
                new ObjectParameter("IsRussian", isRussian) :
                new ObjectParameter("IsRussian", typeof(bool));
    
            var price1hFromParameter = price1hFrom.HasValue ?
                new ObjectParameter("Price1hFrom", price1hFrom) :
                new ObjectParameter("Price1hFrom", typeof(int));
    
            var price1hToParameter = price1hTo.HasValue ?
                new ObjectParameter("Price1hTo", price1hTo) :
                new ObjectParameter("Price1hTo", typeof(int));
    
            var price30minFromParameter = price30minFrom.HasValue ?
                new ObjectParameter("Price30minFrom", price30minFrom) :
                new ObjectParameter("Price30minFrom", typeof(int));
    
            var price30minToParameter = price30minTo.HasValue ?
                new ObjectParameter("Price30minTo", price30minTo) :
                new ObjectParameter("Price30minTo", typeof(int));
    
            var price15minFromParameter = price15minFrom.HasValue ?
                new ObjectParameter("Price15minFrom", price15minFrom) :
                new ObjectParameter("Price15minFrom", typeof(int));
    
            var price15minToParameter = price15minTo.HasValue ?
                new ObjectParameter("Price15minTo", price15minTo) :
                new ObjectParameter("Price15minTo", typeof(int));
    
            var priceAllNightFromParameter = priceAllNightFrom.HasValue ?
                new ObjectParameter("PriceAllNightFrom", priceAllNightFrom) :
                new ObjectParameter("PriceAllNightFrom", typeof(int));
    
            var priceAllNightToParameter = priceAllNightTo.HasValue ?
                new ObjectParameter("PriceAllNightTo", priceAllNightTo) :
                new ObjectParameter("PriceAllNightTo", typeof(int));
    
            var outCallsIdParameter = outCallsId.HasValue ?
                new ObjectParameter("OutCallsId", outCallsId) :
                new ObjectParameter("OutCallsId", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Advertisement>("AdvertisementPagging", mergeOption, totalPages, pageNoParameter, pageSizeParameter, sortColumnParameter, isAscParameter, cityIdParameter, voivodeshipIdParameter, ageFromParameter, ageToParameter, weightFromParameter, weightToParameter, bustSizeFromParameter, bustSizeToParameter, isEnglishParameter, isGermanParameter, isRussianParameter, price1hFromParameter, price1hToParameter, price30minFromParameter, price30minToParameter, price15minFromParameter, price15minToParameter, priceAllNightFromParameter, priceAllNightToParameter, outCallsIdParameter);
        }
    }
}
