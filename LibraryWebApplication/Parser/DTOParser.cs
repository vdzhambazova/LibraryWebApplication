using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;

namespace LibraryWebApplication.Parser
{
    public static class DTOParser
    {
        private static IMapper mapper;

        private static MapperConfiguration mapperConfiguration;

        public static TD Parse<TS,TD>(TS source, TD destination)
        {
            DTOParser.mapperConfiguration = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<TS, TD>();
            });

            DTOParser.mapper = mapperConfiguration.CreateMapper();

            TD convertedDestination = mapper.Map(source, destination);

            return convertedDestination;
        } 
    }
}