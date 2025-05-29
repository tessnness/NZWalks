﻿using AutoMapper;
using NZWalks.API.Controllers.Models.Domain;
using NZWalks.API.Models.DTO;



namespace NZWalks.API.Mappings
{
    public class AutomapperProfiles : Profile
    {

        public AutomapperProfiles()
        {
            CreateMap<Region, RegionDto>().ReverseMap();
            CreateMap<AddRegionRequestDto, Region>().ReverseMap();
            CreateMap<UpdateRegionRequestDto, Region>().ReverseMap();
            CreateMap<AddWalkRequestDto, Walk>().ReverseMap();
            CreateMap<Walk, WalkDto>().ReverseMap();

        }
    }
}
