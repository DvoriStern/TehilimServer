using AutoMapper;
using Common.Dtos;
using Repository.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<ChaptersOfTehilimDto, ChaptersOfTehilim>().ReverseMap();
            CreateMap<GroupDto, Group>().ReverseMap();
            CreateMap< NameForPrayerDto, NameForPrayer>().ReverseMap();
            CreateMap< RequestPrayerDto, RequestPrayer>().ReverseMap();
            CreateMap<SharingDto,Sharing>().ReverseMap();
            CreateMap< UserDto,User > ().ReverseMap();
            CreateMap<ChaptersTehilimToReadDto,ChaptersTehilimToRead>().ReverseMap();

        }
    }
}
