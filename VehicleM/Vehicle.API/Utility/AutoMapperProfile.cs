using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vehicle.API.Models;
using Vehicle.Data.Models;

namespace Vehicle.API.Utility
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<VehiclesModel, Vehicles>();
        }
    }
}
