using AutoMapper;
using Business.Utilities.Mapping.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Mapping
{
    public class MapperHelper : IMapperHelper
    {
        private readonly IMapper _mapper;

        public MapperHelper()
        {
            var profiles = new List<Profile>
        {
            new Profiles()
        };

            var config = new MapperConfiguration(config =>
            {
                foreach (var profile in profiles)
                {
                    config.AddProfile(profile);
                }
            });

            _mapper = config.CreateMapper();
        }
        public TDestination Map<TDestination>(object? source)
        {
            return _mapper.Map<TDestination>(source);
        }

        public void Map(object? source, object? destination)
        {
            _mapper.Map(source, destination);
        }
    }
}
