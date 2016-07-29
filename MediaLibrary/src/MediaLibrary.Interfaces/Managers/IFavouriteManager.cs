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
        IEnumerable<Resource> GetFavouriteResources(Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavouriteResources(ResourceMediaType mediaType, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavouriteResources(int subcategoryId, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavouriteResources(ResourceLocationType location, Dictionary<string, object> opts = null);
    }
}
