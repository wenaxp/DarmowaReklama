using AutoMapper;
using EscortServices.DataAccess.DTOs;
using EscortServices.DataAccess.Model;
using EscortServices.Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscortServices.Rest.Mapper
{
    public class ToAdvertisementPagingViewModel : Profile
    {
        protected override void Configure()
        {
            CreateMap<AdvertisementPaggingDto, AdvertisementPagingViewModel>();
            CreateMap<Advertisement, AdvertisementViewModel>();
        }
    }
}