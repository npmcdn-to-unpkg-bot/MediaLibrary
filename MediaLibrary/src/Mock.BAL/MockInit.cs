using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.BAL
{
    public class MockInit
    {
        public MockInit(ICollection<BasicResourse> resourses)
        {
            InitObject(resourses);
        }


        public bool InitObject(ICollection<BasicResourse> resourses)
        {
            try
            {
                List<MediaCategory> category = new List<MediaCategory> { new MediaCategory { Id = 1, CategoryName = "1" },
                    new MediaCategory {Id = 2, CategoryName="2"}, new MediaCategory { Id= 3, CategoryName="3"} };

                List<MediaSubCategory> subCategory = new List<MediaSubCategory> { new MediaSubCategory { Id=1, Name="1s"},
                    new MediaSubCategory { Id =2, Name="2s"}, new MediaSubCategory { Id=3, Name="3s"} };

                resourses.Add(new MediaLocalResourse { Id = 1, Name = "first", Author = "1a", Bookmark = 0, Location = "path1", Reiting = 5, YearEdition = DateTime.Now, SubCategories = subCategory, Сategories = category });
                resourses.Add(new MediaLocalResourse { Id = 2, Name = "seond", Author = "2a", Bookmark = 0, Location = "path2", Reiting = 5, YearEdition = DateTime.Now, SubCategories = subCategory, Сategories = category });
                resourses.Add(new MediaLocalResourse { Id = 3, Name = "third", Author = "3a", Bookmark = 0, Location = "path3", Reiting = 5, YearEdition = DateTime.Now, SubCategories = subCategory, Сategories = category });

                resourses.Add(new MediaWebResourse { Id = 1, Name = "firstW", Author = "1b", Bookmark = 0, Url = "url1", Reiting = 4.5, YearEdition = DateTime.Now, SubCategories = subCategory, Сategories = category });
                resourses.Add(new MediaWebResourse { Id = 1, Name = "secondW", Author = "2b", Bookmark = 0, Url = "url2", Reiting = 4.5, YearEdition = DateTime.Now, SubCategories = subCategory, Сategories = category });
                resourses.Add(new MediaWebResourse { Id = 1, Name = "thirdW", Author = "3b", Bookmark = 0, Url = "url3", Reiting = 4.5, YearEdition = DateTime.Now, SubCategories = subCategory, Сategories = category });

                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
