using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace SMSC.Domain.Objects
{
    [Serializable]
    [XmlRoot("package", IsNullable = false)]
    public class ErrorResponse
    {
        [XmlElement("error")]
        public string Error { get; set; }

        public static ErrorResponse GetError(string error)
        {
            return new ErrorResponse { Error = error };
        }
    }
}
