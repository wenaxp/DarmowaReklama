using EscortServices.DataAccess.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EscortServices.Rest.Controllers
{
    public class AdvertisementController : ApiController
    {
        private readonly IAdvertisementRepository _advertisementRepository;
        public AdvertisementController(IAdvertisementRepository advertisementRepository)
        {
            _advertisementRepository = advertisementRepository;
        }
        // GET: api/Advertisement
        //public IEnumerable<string> Get()
        //{
        //    int totalPages;
        //    _advertisementRepository.GetList(totalPages, parameters);
        //}
        
    }
}
