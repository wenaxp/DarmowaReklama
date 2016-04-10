using AutoMapper;
using EscortServices.DataAccess.DTOs;
using EscortServices.Rest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EscortServices.Rest.Mapper
{
    public class ToAdvertisementPaggingDto:Profile
    {
        protected override void Configure()
        {
            CreateMap<AdvertisementPagingViewModel, AdvertisementPaggingDto>();
        }
    }
}