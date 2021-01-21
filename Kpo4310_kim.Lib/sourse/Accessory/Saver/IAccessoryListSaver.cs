using System.Collections.Generic;

namespace Kpo4310.kim.Lib
{
    public interface IAccessoryListSaver
    {
        List<Accessory> accessoryList { set; }
        LoadStatus status { get; }

        void Execute();
    }
}