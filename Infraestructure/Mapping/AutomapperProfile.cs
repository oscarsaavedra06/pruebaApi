﻿using AutoMapper;
using Core.DTO;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure.Mapping
{
    public class AutomapperProfile : Profile 
    {
        public AutomapperProfile()
        {
            CreateMap<SolicitudIngreso, SolicitudIngresoDTO>().ReverseMap();
        }
    }
}
