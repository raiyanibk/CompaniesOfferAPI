﻿using System;
using System.Collections.Generic;
using System.Text;
using AutoMapper;
using CompaniesOfferAPI.Util.Models;

namespace CompaniesOfferAPI.Util.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RX2APIRequest, OfferRequest>()
                .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.warehouseaddress))
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.contactaddress))
                .ForMember(dest => dest.Carton, opt => opt.MapFrom(src => src.packagedimensions));
            
            CreateMap<FedXAPIRequest, OfferRequest>()
                 .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.consignee))
                 .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.consignor))
                 .ForMember(dest => dest.Carton, opt => opt.MapFrom(src => src.cartons));

            CreateMap<PremierAPIRequest, OfferRequest>()
               .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.source))
               .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.destination))
               .ForMember(dest => dest.Carton, opt => opt.MapFrom(src => src.packagedimensions));
        }
    }
}