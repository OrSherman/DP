using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace A18_Ex01_Tal_204271175_Or_311356711
{
    public class AppSettings
    {
        private const string k_MyAppId = "1450160541956417";
        private const string k_FileForXML = @"D:\AppSettings.xml";
        public bool RememberUser { get; set; }
        public string LastAccessToken { get; set; }
        public Point LastWindowLocation { get; set; }
        public Size LastWindowSize { get; set; }
        public string AppId { get; set; }

        private AppSettings()
        {
            RememberUser = false;
            LastWindowLocation = new Point(60, 42);
            LastWindowSize = new Size(842, 591);
            AppId = k_MyAppId;
        }

        public static AppSettings LoadFromFile()
        {
            AppSettings appSettings = new AppSettings();
            if (File.Exists(k_FileForXML))
            {
                using (Stream stream = new FileStream(k_FileForXML, FileMode.Open))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(AppSettings));
                    appSettings = serializer.Deserialize(stream) as AppSettings;
                }
            }

            if (string.IsNullOrEmpty(appSettings.AppId))
            {
                appSettings.AppId = k_MyAppId;
            }

            return appSettings;
        }

        public void SaveToFile()
        {
            using (Stream stream = new FileStream(k_FileForXML, FileMode.Create))
            {
                XmlSerializer serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stream, this);
            }
        }
    }
}
