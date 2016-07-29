using MediaLibrary.Interfaces.Enums;
using Mock.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Interfaces.Managers
{
    public interface IFavouriteManager
    {
        IEnumerable<Resource> GetFavouriteResources();

        IEnumerable<Resource> GetFavouriteResources(ResourceMediaType mediaType);

        IEnumerable<Resource> GetFavouriteResources(int subcategoryId);

        IEnumerable<Resource> GetFavouriteResources(ResourceLocationType location);
    }
}
