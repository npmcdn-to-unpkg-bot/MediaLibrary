using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.BAL
{
    public abstract class Resource
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public DateTime YearEdition { get; set; }
        public double Rating { get; set; }

        public int NumOfViews { get; set; }

        public bool IsFavourite { get; set; }

        public ResourceMediaType MediaType { get; set; }

        public double BookmarkPosition { get; set; }

        public double Length { get; set; }
        //public virtual ICollection<MediaCategory> Сategories { get; set; }
        public MediaSubCategory SubCategory { get; set; }

        public string Address { get; set; }

        public Location Location { get; set; }

        // to do: add calculated recourse info property 


        //public abstract string GetAdress();

        //public abstract void UpdateRating(double additionalMark);
    }

    public enum ResourceMediaType
    {
        Text,
        Audio,
        Video
    }

    public enum Location{
        Local,
        Web
    }
}
