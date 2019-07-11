using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SMSC.Domain.Objects
{
    [Serializable]
    [XmlRoot(ElementName = "package", IsNullable = false)]
    public class PackageResponse
    {
        [XmlArray("send")]
        [XmlArrayItem("message", IsNullable = false)]
        public List<ResponseMsg> Send { get; set; }
    }
}
