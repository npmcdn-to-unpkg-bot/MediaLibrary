using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Mock.BAL
{
    public class MediaWebResourse: BasicResourse
    {
        public MediaWebResourse()
        {

        }

        public override string GetAdress()
        {
            return Url;
        }

        public override void EditRaiting(double additionalMark)
        {
            throw new NotImplementedException();
        }

        public string Url { private get; set; }

    }
}
