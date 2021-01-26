using System;
using System.Drawing;
using System.IO;
using System.Xml.Serialization;

namespace ScreenDraw
{
    public class Configuration
    {
        private const string ConfigFileName = "cfg.xml";
        public Configuration()
        {
            Color1 = Color.Blue;
            Color2 = Color.Green;
            TraceWidth = 3;
        }

        public SerializableColor Color1 { get; set; }
        public SerializableColor Color2 { get; set; }
        public int TraceWidth { get; set; }

        internal void SaveConfig()
        {
            using (var fs = File.OpenWrite(ConfigFileName))
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                serializer.Serialize(fs, this);
            }
        }
        internal static Configuration LoadConfig()
        {
            if (!File.Exists(ConfigFileName)) return new Configuration();

            using (var fs = File.OpenRead(ConfigFileName))
            {
                var serializer = new XmlSerializer(typeof(Configuration));
                return (Configuration)serializer.Deserialize(fs);
            }
        }
    }
    public class SerializableColor
    {
        private Color internalColor = Color.Black;

        public SerializableColor() { }
        public SerializableColor(Color c) { internalColor = c; }

        public static implicit operator Color(SerializableColor x)
        {
            return x.internalColor;
        }
        public static implicit operator SerializableColor(Color c)
        {
            return new SerializableColor(c);
        }

        [XmlAttribute]
        public string HtmlColor
        {
            get { return ColorTranslator.ToHtml(internalColor); }
            set { internalColor = ColorTranslator.FromHtml(value); }
        }
    }
}
