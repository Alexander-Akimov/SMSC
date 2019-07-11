using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SMSC.Domain.Objects
{
    public class ResponseMsg
    {
        [XmlAttribute("id")]
        public int Id { get; set; }

        [XmlAttribute("server_id")]
        public string ServerId { get; set; }

        [XmlText]
        public string Value { get; set; }

        [XmlElement("error", IsNullable = true)]
        public string MsgErrorCode { get; set; }
    }
}
