using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.BAL
{
    public class MediaSubCategory
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public MediaCategory Category { get; set; }

    }
}
