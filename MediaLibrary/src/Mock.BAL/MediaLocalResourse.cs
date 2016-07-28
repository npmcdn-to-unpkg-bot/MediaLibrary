using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.BAL
{
    public class MediaLocalResourse: BasicResourse
    {
        public MediaLocalResourse()
        {

        }

        public override string GetAdress()
        {
            return Location;
        }
        public override string ToString()
        {
            return this.Name;                   //we are need this method??
        }

        public override void EditRaiting(double additionalMark)
        {
            throw new NotImplementedException();
        }

        public string Location { private get; set; }

    }
}
