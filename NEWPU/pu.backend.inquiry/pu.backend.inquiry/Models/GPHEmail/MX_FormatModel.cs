using System.Xml.Serialization;
using System.IO;
using System;
namespace pu.backend.inquiry.Models.GPHEmail
{
    [XmlRoot("Document", Namespace = "urn:iso:std:iso::20022:tech:xsd:pain.001.001.03")]
    public class Document
    {
        [XmlElement("CstmrCdtTrfInitn")]
        public CstmrCdtTrfInitn CstmrCdtTrfInitn { get; set; }
    }

    public class CstmrCdtTrfInitn
    {
        [XmlElement("GrpHdr")]
        public GrpHdr GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PmtInf PmtInf { get; set; }
    }

    public class GrpHdr
    {
        [XmlElement("MsgId")]
        public string MsgId { get; set; }

        [XmlElement("CreDtTm")]
        public DateTime CreDtTm { get; set; }

        [XmlElement("NbOfTxs")]
        public int NbOfTxs { get; set; }

        [XmlElement("InitgPty")]
        public string InitgPty { get; set; } // Add proper structure if needed
    }

    public class PmtInf
    {
        [XmlElement("PmtInfId")]
        public string PmtInfId { get; set; }

        [XmlElement("PmtMtd")]
        public string PmtMtd { get; set; }

        [XmlElement("RewdExctnDt")]
        public DateTime RewdExctnDt { get; set; }

        [XmlElement("Dbtr")]
        public string Dbtr { get; set; } // Add proper structure if needed

        [XmlElement("DbtrAcct")]
        public DbtrAcct DbtrAcct { get; set; }
    }

    public class DbtrAcct
    {
        [XmlElement("Id")]
        public Id Id { get; set; }
    }

    public class Id
    {
        [XmlElement("Othr")]
        public Othr Othr { get; set; }
    }

    public class Othr
    {
        [XmlElement("Id")]
        public string Id { get; set; }
    }


}
