﻿using AutoMapper;
using Models.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Models.Mapper
{
    public class TipoPermisoProfileMap : Profile
    {
        public TipoPermisoProfileMap()
        {
            CreateMap<TipoPermisos, TipoPermisoDto>().ReverseMap();
        }
    }
}
