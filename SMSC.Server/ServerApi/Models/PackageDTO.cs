using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace SMSC.Server.ServerApi.Models
{
    [Serializable]
    [XmlRoot(ElementName = "package", IsNullable = false)]
    public class PackageDTO
    {
        //[XmlElement("send")]
        [XmlArray("send")]
        [XmlArrayItem("message", IsNullable = false)]
        public List<Message> Send { get; set; }

        [XmlAttribute("login")]
        public string Login { get; set; }

        [XmlAttribute("password")]
        public string Password { get; set; }
        /*public PackageDTO()
        {
            Send = new List<Message>();
        }*/
    }
}
