using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Kpo4310.Lib;

namespace Kpo4310.kim.Lib
{
    public class AccessorySplitFileFactory : IAccessoryFactory
    {
        public IAccessoryListLoader CreateAccessoryListLoader()
        {
            return new AccessoryListSplitFileLoader(AppGlobalSettings.dataFileName);
        }
        public IAccessoryListSaver CreateAccessoryListSaver()
        {
            return new AccessoryListSplitFileSaver(AppGlobalSettings.dataFileName);

        }
    }
}
