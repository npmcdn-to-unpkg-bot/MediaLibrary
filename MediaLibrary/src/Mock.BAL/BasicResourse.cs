using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.BAL
{
    public abstract class BasicResourse
    {
        public virtual int Id { get; set; }
        public virtual string Name { get; set; }
        public virtual string Author { get; set; }
        public virtual DateTime YearEdition { get; set; }
        public virtual double Reiting { get; set; }
        public virtual double Bookmark { get; set; }
        public virtual ICollection<MediaCategory> Сategories { get; set; }
        public virtual ICollection<MediaSubCategory> SubCategories { get; set; }


        public abstract string GetAdress();

        public abstract void EditRaiting(double additionalMark);
    }
}
