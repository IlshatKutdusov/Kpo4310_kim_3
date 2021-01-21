using System.Configuration;

namespace Kpo4310.Utility
{
    public class AppConfigUtility
    {
        public string AppSettings(string name)
        {
            //Если конфигурационный параметр определен 
            //то
            //..вернуть значение параметра в виде строки 
            //иначе
            //..вернуть пустою строку

            string appSettings = ConfigurationManager.AppSettings[name];
            if (appSettings != null)
                return appSettings;
            else
                return "";
        }
    }
}
