using EscortServices.DataAccess.DTOs;
using EscortServices.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EscortServices.DataAccess.Repository
{
    public interface IAdvertisementRepository
    {
        Advertisement Get(string publicId);
        void Save(Advertisement advertisement);
        AdvertisementPaggingDto GetAdvertisementPagging(AdvertisementPaggingDto advPagging);
    }
}
