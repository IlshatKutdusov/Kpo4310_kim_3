using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace Kpo4310.kim.Lib
{
    public class AccessoryListSplitFileSaver : IAccessoryListSaver
    {
        private readonly string _datafilename;
        private List<Accessory> _accessoryList;
        public AccessoryListSplitFileSaver(string datafilename)
        {
            _datafilename = datafilename;
            _accessoryList = null;
        }

        public List<Accessory> accessoryList
        {
            set => _accessoryList = value;
        }

        private LoadStatus _status = LoadStatus.None;
        public LoadStatus status { get => _status; }

        public void Execute()
        {
            _status = LoadStatus.None;

            if (_datafilename == "")
            {
                _status = LoadStatus.FileNameIsEmpty;
                throw new Exception("Путь к файлу пуст");
            }

            if (_accessoryList == null)
            {
                _status = LoadStatus.NoData;
                throw new Exception("Данных нет");
            }

            using (StreamWriter sw = new StreamWriter(_datafilename, false))
            {
                if (_accessoryList.Count != 0)
                    for (int i = 0; i < _accessoryList.Count; i++)
                    {
                        try
                        {
                            Accessory accessory = _accessoryList.ElementAt(i);
                            sw.WriteLine(accessory.name + '#' + accessory.type + '#' + accessory.value + '#' + accessory.quantity);
                        }
                        catch (Exception ex)
                        {
                            LogUtility.ErrorLog(ex);
                            _status = LoadStatus.GeneralError;
                        }
                    }
            }
            _status = LoadStatus.Success;
            MessageBox.Show("Сохранено! (AccessoryListSplitFileSaver)");
        }
    }
}
