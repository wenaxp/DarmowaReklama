using AutoMapper;
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
            CreateMap<Advertisement, AdvertisementViewModel>();
            CreateMap<IEnumerable<Advertisement>, AdvertisementPagingViewModel>()
                .ForMember(x=>x.List,y=>y.MapFrom(z=>z));
        }
    }
}