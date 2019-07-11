using System.Xml.Serialization;

namespace SMSC.Server.ServerApi.Models
{
    public class Message
    {
        [XmlAttribute("id")]
        public string Id { get; set; }

        [XmlAttribute("receiver")]
        public string Receiver { get; set; }

        [XmlAttribute("sender")]
        public string Sender { get; set; }

        [XmlText]
        public string Value { get; set; }
    }
}
