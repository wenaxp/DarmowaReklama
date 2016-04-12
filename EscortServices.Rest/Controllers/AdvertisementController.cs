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

        [HttpPost]
        public void Save(AdvertisementViewModel vModel)
        {
            var advertisementPaggingDto = _mapper.Map<AdvertisementViewModel, Advertisement>(vModel);
            _advertisementRepository.Save(advertisementPaggingDto);
        }

        [HttpGet]
        public AdvertisementViewModel Get(string publicId)
        {
            var advertisermentList = _advertisementRepository.Get(publicId);
            var vModel = _mapper.Map<Advertisement, AdvertisementViewModel>(advertisermentList);
            return vModel;
        }

        [HttpGet]
        public AdvertisementPagingViewModel GetList(AdvertisementPagingViewModel vModel)
        {
            var advertisementPaggingDto = _mapper.Map<AdvertisementPagingViewModel, AdvertisementPaggingDto>(vModel);
            var advertisermentList = _advertisementRepository.GetAdvertisementPagging(advertisementPaggingDto);
            vModel = _mapper.Map<AdvertisementPaggingDto, AdvertisementPagingViewModel>(advertisermentList, vModel);
            return vModel;
        }

    }
}
