using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediaLibrary.Interfaces.Managers
{
    interface IManagerFirstVesion
    {
        /// <summary>
        /// Get resource by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        bool GetResourse(Int32 id);

        IEnumerable<BasicResourse> GetResoursesByMediaType(MediaResourseType resourceMediaType);
        IEnumerable<BasicResourse> GetResoursesByCategory(MediaCategoryType category);
        IEnumerable<BasicResourse> GetFavoriteResourses();
        IEnumerable<BasicResourse> GetFavoriteResoursesByMediaType(MediaResourseType resourceMediaType);
        IEnumerable<BasicResourse> GetFavoriteResoursesByCategory(MediaCategoryType resourceMediaType);

        bool DeleteResourse(Int32 id);
        bool DeleteResoursesByMediaType(MediaResourseType resourceMediaType);
        bool DeleteResoursesByCategory(MediaCategoryType category);
        bool DeleteUnFavoriteResources();

        bool AddResource(BasicResourse recource);
        IEnumerable<BasicResourse> AddResources(List<BasicResourse> recources);

        bool UpdateResource(BasicResourse recource);
        IEnumerable<BasicResourse> UpdateResources(List<BasicResourse> recources);


        MediaCategoryType AddResourceCategory();
    }
}
