using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace SMSC.Domain.Objects
{
    [Serializable]
    [XmlRoot(ElementName = "package", IsNullable = false)]
    public class PackageRequest
    {
        [XmlArray("send")]
        [XmlArrayItem("message", IsNullable = false)]
        public List<RequestMsg> Send { get; set; }

        [XmlAttribute("login")]
        public string Login { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }
    }
}
