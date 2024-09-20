using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Utilities.Mapping.Interface;

public interface IMapperHelper
{
        TDestination Map<TDestination>(object? source);
        void Map(object? source, object? destination);
}
