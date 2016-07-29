using MediaLibrary.Interfaces.Enums;
using Mock.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Interfaces.Managers
{
    public interface IResourceManager
    {
        Resource Get(int resourceId);
        IEnumerable<Resource> GetMany(int[] resourcesId, Dictionary<string, object> opts = null);
        IEnumerable<Resource> GetMany(ResourceMediaType mediaType, Dictionary<string, object> opts = null);
        IEnumerable<Resource> GetMany(int subcategoryId, Dictionary<string, object> opts = null);
        IEnumerable<Resource> GetMany(ResourceLocationType location, Dictionary<string, object> opts = null);

        bool Delete(int resourceId);

        int Add(Resource resource);

        int Update(Resource recource);
    }
}
