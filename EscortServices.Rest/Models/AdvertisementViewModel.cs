using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscortServices.Rest.Models
{
    public class AdvertisementViewModel
    {
        public string Password { get; set; }
        public string Name { get; set; }
        public short CityId { get; set; }
        public string CityName { get; set; }
        public short VoivodeshipId { get; set; }
        public byte VoivodeshipName { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public string Telephone { get; set; }
        public byte Age { get; set; }
        public byte Weight { get; set; }
        public string BustSize { get; set; }
        public bool IsEnglish { get; set; }
        public bool IsGerman { get; set; }
        public bool IsRussian { get; set; }
        public short Price1h { get; set; }
        public short Price30min { get; set; }
        public short Price15min { get; set; }
        public short PriceAllNight { get; set; }
        public byte OutCallsId { get; set; }
        public TimeSpan? MonFrom { get; set; }
        public TimeSpan? MonTo { get; set; }
        public TimeSpan? TueFrom { get; set; }
        public TimeSpan? TueTo { get; set; }
        public TimeSpan? WedFrom { get; set; }
        public TimeSpan? WedTo { get; set; }
        public TimeSpan? ThuFrom { get; set; }
        public TimeSpan? ThuTo { get; set; }
        public TimeSpan? FriFrom { get; set; }
        public TimeSpan? FroTo { get; set; }
        public TimeSpan? SatFrom { get; set; }
        public TimeSpan? SatTo { get; set; }
        public TimeSpan? SunFrom { get; set; }
        public TimeSpan? SunTo { get; set; }
        public string ContentPL { get; set; }
        public string ContentEN { get; set; }
        public string ContentDE { get; set; }
        public string ContentRU { get; set; }
        public string PublicId { get; set; }
        public DateTime Date { get; set; }
    }
}