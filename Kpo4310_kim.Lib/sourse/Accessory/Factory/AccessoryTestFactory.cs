using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kpo4310.kim.Lib
{
    public class AccessoryTestFactory : IAccessoryFactory
    {

        public IAccessoryListLoader CreateAccessoryListLoader()
        {
            return new AccessoryListTestLoader();
        }

        public IAccessoryListSaver CreateAccessoryListSaver()
        {
            return new AccessoryListTestSaver();
        }
    }
}
