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
        IEnumerable<Resource> GetFavourites(Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(ResourceMediaType mediaType, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(int subcategoryId, Dictionary<string, object> opts = null);

        IEnumerable<Resource> GetFavourites(ResourceLocationType location, Dictionary<string, object> opts = null);

        int AddFavourite(int recourseId);

        bool DeleteFavourite(int recourseId);
    }
}
