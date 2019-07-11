using System.Xml.Serialization;

namespace SMSC.Domain.Objects
{
    public class RequestMsg
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
