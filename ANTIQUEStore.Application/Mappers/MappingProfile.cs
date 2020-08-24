using ANTIQUEStore.Application.DTOs;
using ANTIQUEStore.Domain.Domain;
using AutoMapper;

namespace ANTIQUEStore.Application.Mappers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Item, ItemDTO>().ReverseMap();
        }
    }
}
