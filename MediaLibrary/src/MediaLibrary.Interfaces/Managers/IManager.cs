using MediaLibrary.Interfaces.Enums;
using Mock.BAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Interfaces.Managers
{
    public interface IManager
    {
        Resource GetResource(int resourceId);
        IEnumerable<Resource> GetResources(int[] resourcesId);
        IEnumerable<Resource> GetResourses(ResourceMediaType mediaType);
        IEnumerable<Resource> GetResourses(int subcategoryId);
        IEnumerable<Resource> GetResourses(ResourceLocationType location);

        bool DeleteResource(int resourceId);

        int AddResource(Resource resource);

        int UpdateResource(Resource recource);
    }
}
