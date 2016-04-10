using AutoMapper;
using EscortServices.DataAccess.DTOs;
using EscortServices.DataAccess.Model;
using EscortServices.DataAccess.Repository;
using EscortServices.Rest.Models;
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
        private readonly IMapper _mapper;
        public AdvertisementController(IMapper mapper, IAdvertisementRepository advertisementRepository)
        {
            _advertisementRepository = advertisementRepository;
            _mapper = mapper;
        }
        [HttpGet]
        //GET: api/Advertisement
        public AdvertisementPagingViewModel GetList(AdvertisementPagingViewModel vModel)
        {
            vModel = vModel ?? new AdvertisementPagingViewModel();
            var advertisementPaggingDto = _mapper.Map<AdvertisementPagingViewModel, AdvertisementPaggingDto>(vModel);
            int totalPages;
            var advertisermentList = _advertisementRepository.GetList(out totalPages, advertisementPaggingDto);
            vModel.TotalPages = totalPages;
            vModel = _mapper.Map<IEnumerable<Advertisement>, AdvertisementPagingViewModel>(advertisermentList,vModel);
            return vModel;
        }

    }
}
