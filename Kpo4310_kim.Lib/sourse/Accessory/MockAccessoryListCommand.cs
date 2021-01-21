using System;
using System.Collections.Generic;

namespace Kpo4310.kim.Lib
{
    public class MockAccessoryListCommand
    {  
        public MockAccessoryListCommand()
        {
            this._accessoryList = new List<Accessory>();
        }

        private readonly string _dataFileName = "";
        private List<Accessory> _accessoryList = new List<Accessory>();

        public List<Accessory> accessoryList
        {
            get { return _accessoryList; }
        }

        public void Execute()
        {
            try
            {
                {
                    Accessory accessory = new Accessory()
                    {
                        name = "RT-11-24",
                        type = "R",
                        value = "100000",
                        quantity = "12"
                    };

                    accessoryList.Add(accessory);
                }

                {
                    Accessory accessory = new Accessory()
                    {
                        name = "RT-11-24",
                        type = "R",
                        value = "50000",
                        quantity = "10"
                    };

                    accessoryList.Add(accessory);
                }

                {
                    Accessory accessory = new Accessory()
                    {
                        name = "CGU-12K",
                        type = "C",
                        value = "17.5",
                        quantity = "3"
                    };

                    accessoryList.Add(accessory);
                }
            }
            catch (Exception ex)
            {
                LogUtility.ErrorLog(ex);
            }
        }
    }
}
