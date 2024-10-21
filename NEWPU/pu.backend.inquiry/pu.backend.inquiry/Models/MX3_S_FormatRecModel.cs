using System.Xml.Serialization;
using System;
using System.Collections.Generic;
namespace pu.backend.inquiry.Models
{
    [XmlRoot(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.03")]
    public class MX3_S_Document
    {
        [XmlElement(ElementName = "CstmrCdtTrfInitn")]
        public MX3_S_CstmrCdtTrfInitn CstmrCdtTrfInitn { get; set; }
    }

    public class MX3_S_CstmrCdtTrfInitn
    {
        [XmlElement(ElementName = "GrpHdr")]
        public MX3_S_GrpHdr GrpHdr { get; set; }

        [XmlElement(ElementName = "PmtInf")]
        public List<PmtInf> PmtInf { get; set; }
    }

    public class MX3_S_GrpHdr
    {
        [XmlElement(ElementName = "MsgId")]
        public string MsgId { get; set; }

        [XmlElement(ElementName = "CreDtTm")]
        public DateTime CreDtTm { get; set; }

        [XmlElement(ElementName = "NbOfTxs")]
        public int NbOfTxs { get; set; }

        [XmlElement(ElementName = "InitgPty")]
        public string InitgPty { get; set; } // Assuming this could be more complex, adjust as needed
    }

    public class PmtInf
    {
        [XmlElement(ElementName = "PmtInfId")]
        public string PmtInfId { get; set; }

        [XmlElement(ElementName = "PmtMtd")]
        public string PmtMtd { get; set; }

        [XmlElement(ElementName = "ReqdExctnDt")]
        public DateTime ReqdExctnDt { get; set; }

        [XmlElement(ElementName = "Dbtr")]
        public string Dbtr { get; set; } // Assuming this could be more complex, adjust as needed

        [XmlElement(ElementName = "DbtrAcct")]
        public MX3_S_DbtrAcct DbtrAcct { get; set; }

        [XmlElement(ElementName = "DbtrAgt")]
        public MX3_S_DbtrAgt DbtrAgt { get; set; }

        [XmlElement(ElementName = "CdtTrfTxInf")]
        public List<MX3_S_CdtTrfTxInf> CdtTrfTxInf { get; set; }
    }

    public class MX3_S_DbtrAcct
    {
        [XmlElement(ElementName = "Id")]
        public MX3_S_Id Id { get; set; }
    }

    public class MX3_S_Id
    {
        [XmlElement(ElementName = "Othr")]
        public MX3_S_Othr Othr { get; set; }
    }

    public class MX3_S_Othr
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
    }

    public class MX3_S_DbtrAgt
    {
        [XmlElement(ElementName = "FinInstnId")]
        public string FinInstnId { get; set; } // Assuming this could be more complex, adjust as needed
    }

    public class MX3_S_CdtTrfTxInf
    {
        [XmlElement(ElementName = "PmtId")]
        public MX3_S_PmtId PmtId { get; set; }

        [XmlElement(ElementName = "PmtTpInf")]
        public MX3_S_PmtTpInf PmtTpInf { get; set; }

        [XmlElement(ElementName = "Amt")]
        public MX3_S_Amt Amt { get; set; }

        [XmlElement(ElementName = "ChrgBr")]
        public string ChrgBr { get; set; }

        [XmlElement(ElementName = "CdtrAgt")]
        public MX3_S_CdtrAgt CdtrAgt { get; set; }

        [XmlElement(ElementName = "Cdtr")]
        public MX3_S_Cdtr Cdtr { get; set; }

        [XmlElement(ElementName = "CdtrAcct")]
        public MX3_S_CdtrAcct CdtrAcct { get; set; }

        [XmlElement(ElementName = "InstrForDbtrAgt")]
        public string InstrForDbtrAgt { get; set; }

        [XmlElement(ElementName = "RgltryRptg")]
        public List<MX3_S_RgltryRptg> RgltryRptg { get; set; }

        [XmlElement(ElementName = "RltdRmtInf")]
        public List<MX3_S_RltdRmtInf> RltdRmtInf { get; set; }

        [XmlElement(ElementName = "RmtInf")]
        public MX3_S_RmtInf RmtInf { get; set; }
    }

    public class MX3_S_PmtId
    {
        [XmlElement(ElementName = "InstrId")]
        public string InstrId { get; set; }

        [XmlElement(ElementName = "EndToEndId")]
        public string EndToEndId { get; set; }
    }

    public class MX3_S_PmtTpInf
    {
        [XmlElement(ElementName = "LclInstrm")]
        public MX3_S_LclInstrm LclInstrm { get; set; }
    }

    public class MX3_S_LclInstrm
    {
        [XmlElement(ElementName = "Prtry")]
        public string Prtry { get; set; }
    }

    public class MX3_S_Amt
    {
        [XmlElement(ElementName = "InstdAmt")]
        public MX3_S_InstdAmt InstdAmt { get; set; }
    }

    public class MX3_S_InstdAmt
    {
        [XmlAttribute(AttributeName = "Ccy")]
        public string Ccy { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }

    public class MX3_S_CdtrAgt
    {
        [XmlElement(ElementName = "FinInstnId")]
        public MX3_S_FinInstnId FinInstnId { get; set; }
    }

    public class MX3_S_FinInstnId
    {
        [XmlElement(ElementName = "Nm")]
        public string Nm { get; set; }

        [XmlElement(ElementName = "BIC")]
        public string BIC { get; set; } // Include if needed
    }

    public class MX3_S_Cdtr
    {
        [XmlElement(ElementName = "Nm")]
        public string Nm { get; set; }

        [XmlElement(ElementName = "PstlAdr")]
        public MX3_S_PstlAdr PstlAdr { get; set; }
    }

    public class MX3_S_PstlAdr
    {
        [XmlElement(ElementName = "TwnNm")]
        public string TwnNm { get; set; }

        [XmlElement(ElementName = "Ctry")]
        public string Ctry { get; set; }
    }

    public class MX3_S_RgltryRptg
    {
        [XmlElement(ElementName = "DbtCdtRptgInd")]
        public string DbtCdtRptgInd { get; set; }

        [XmlElement(ElementName = "Authrty")]
        public string Authrty { get; set; } // Assuming this could be more complex, adjust as needed

        [XmlElement(ElementName = "Dtls")]
        public MX3_S_Dtls Dtls { get; set; }
    }

    public class MX3_S_Dtls
    {
        [XmlElement(ElementName = "Inf")]
        public string Inf { get; set; }
    }

    public class MX3_S_RltdRmtInf
    {
        [XmlElement(ElementName = "RmtLctnMtd")]
        public string RmtLctnMtd { get; set; }

        [XmlElement(ElementName = "RmtLctnElctrncAdr")]
        public string RmtLctnElctrncAdr { get; set; }
    }

    public class MX3_S_RmtInf
    {
        [XmlElement(ElementName = "Ustrd")]
        public string Ustrd { get; set; }

        [XmlElement(ElementName = "Strd")]
        public MX3_S_Strd Strd { get; set; }
    }

    public class MX3_S_Strd
    {
        [XmlElement(ElementName = "RfrdDocInf")]
        public MX3_S_RfrdDocInf RfrdDocInf { get; set; }

        [XmlElement(ElementName = "RfrdDocAmt")]
        public MX3_S_RfrdDocAmt RfrdDocAmt { get; set; }

        [XmlElement(ElementName = "CdtrRefInf")]
        public MX3_S_CdtrRefInf CdtrRefInf { get; set; }

        [XmlElement(ElementName = "AddtlRmtInf")]
        public string AddtlRmtInf { get; set; }
    }

    public class MX3_S_RfrdDocInf
    {
        [XmlElement(ElementName = "Nb")]
        public string Nb { get; set; }
    }

    public class MX3_S_RfrdDocAmt
    {
        [XmlElement(ElementName = "RmtdAmt")]
        public MX3_S_RmtdAmt RmtdAmt { get; set; }
    }

    public class MX3_S_RmtdAmt
    {
        [XmlAttribute(AttributeName = "Ccy")]
        public string Ccy { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }

    public class MX3_S_CdtrRefInf
    {
        [XmlElement(ElementName = "Ref")]
        public string Ref { get; set; }
    }

}
