using AutoMapper;
using CompaniesOfferAPI.Util.Dtos;

namespace CompaniesOfferAPI.Util.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<RX2APIRequest, ServiceChargeRequest>()
                .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.WarehouseAddress))
                .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.ContactAddress))
                .ForMember(dest => dest.Carton, opt => opt.MapFrom(src => src.PackageDimensions));
            
            CreateMap<FedXAPIRequest, ServiceChargeRequest>()
                 .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.Consignee))
                 .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Consignor))
                 .ForMember(dest => dest.Carton, opt => opt.MapFrom(src => src.Cartons));

            CreateMap<PremierAPIRequest, ServiceChargeRequest>()
               .ForMember(dest => dest.Source, opt => opt.MapFrom(src => src.Source))
               .ForMember(dest => dest.Destination, opt => opt.MapFrom(src => src.Destination))
               .ForMember(dest => dest.Carton, opt => opt.MapFrom(src => src.PackageDimensions));
        }
    }
}
