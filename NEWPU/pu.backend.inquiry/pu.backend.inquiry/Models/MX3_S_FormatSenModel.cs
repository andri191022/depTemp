using System.Xml.Serialization;
using System;
using System.Collections.Generic;

namespace pu.backend.inquiry.Models
{
    [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain002.001.03")]
    public class MX3_S_FormatSenModel
    {
        [XmlElement("CstmrPmtStsRpt")]
        public MX3_S_S_CustomerPaymentStatusReport CstmrPmtStsRpt { get; set; }
    }

    public class MX3_S_S_CustomerPaymentStatusReport
    {
        [XmlElement("GrpHdr")]
        public MX3_S_S_GroupHeader GrpHdr { get; set; }

        [XmlElement("OrgnlGrpInfAndSts")]
        public MX3_S_S_OriginalGroupInformationAndStatus OrgnlGrpInfAndSts { get; set; }

        [XmlElement("OrgnlPmtInfAndSts")]
        public MX3_S_S_OriginalPaymentInformationAndStatus OrgnlPmtInfAndSts { get; set; }
    }

    public class MX3_S_S_GroupHeader
    {
        [XmlElement("MsgId")]
        public string MsgId { get; set; }

        [XmlElement("CreDtTm")]
        public DateTime CreDtTm { get; set; }
    }

    public class MX3_S_S_OriginalGroupInformationAndStatus
    {
        [XmlElement("OrgnlMsgId")]
        public string OrgnlMsgId { get; set; }

        [XmlElement("OrgnlMsgNmId")]
        public string OrgnlMsgNmId { get; set; }

        [XmlElement("GrpSts")]
        public string GrpSts { get; set; }

        [XmlElement("StsRsnInf")]
        public MX3_S_S_StatusReasonInformation StsRsnInf { get; set; }
    }

    public class MX3_S_S_StatusReasonInformation
    {
        [XmlElement("Rsn")]
        public MX3_S_S_Reason Rsn { get; set; }
    }

    public class MX3_S_S_Reason
    {
        [XmlElement("Prtry")]
        public string Prtry { get; set; }
    }

    public class MX3_S_S_OriginalPaymentInformationAndStatus
    {
        [XmlElement("OrgnlPmtInfId")]
        public string OrgnlPmtInfId { get; set; }

        [XmlElement("TxInfAndSts")]
        public List<MX3_S_S_TransactionInformationAndStatus> TxInfAndSts { get; set; }
    }

    public class MX3_S_S_TransactionInformationAndStatus
    {
        [XmlElement("StsId")]
        public string StsId { get; set; }

        [XmlElement("OrgnlInstrId")]
        public string OrgnlInstrId { get; set; }

        [XmlElement("OrgnlEndToEndId")]
        public string OrgnlEndToEndId { get; set; }

        [XmlElement("TxSts")]
        public string TxSts { get; set; }

        [XmlElement("StsRsnInf")]
        public MX3_S_S_StatusReasonInformation StsRsnInf { get; set; }

        [XmlElement("OrgnlTxRef")]
        public MX3_S_S_OriginalTransactionReference OrgnlTxRef { get; set; }
    }

    public class MX3_S_S_OriginalTransactionReference
    {
        [XmlElement("Amt")]
        public MX3_S_S_Amount Amt { get; set; }

        [XmlElement("ReqdExctnDt")]
        public DateTime ReqdExctnDt { get; set; }

        [XmlElement("DbtrAcct")]
        public MX3_S_S_DebtorAccount DbtrAcct { get; set; }

        [XmlElement("DbtrAgt")]
        public MX3_S_S_DebtorAgent DbtrAgt { get; set; }

        [XmlElement("CdtrAgt")]
        public MX3_S_S_CreditorAgent CdtrAgt { get; set; }

        [XmlElement("Cdtr")]
        public MX3_S_S_Creditor Cdtr { get; set; }

        [XmlElement("CdtrAcct")]
        public MX3_S_S_CreditorAccount CdtrAcct { get; set; }
    }

    public class MX3_S_S_Amount
    {
        [XmlElement("InstdAmt")]
        public MX3_S_S_InstructedAmount InstdAmt { get; set; }
    }

    public class MX3_S_S_InstructedAmount
    {
        [XmlAttribute("Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal AmountValue { get; set; }
    }

    public class MX3_S_S_DebtorAccount
    {
        [XmlElement("Id")]
        public MX3_S_S_AccountId Id { get; set; }
    }

    public class MX3_S_S_AccountId
    {
        [XmlElement("Othr")]
        public MX3_S_S_Other Other { get; set; }
    }

    public class MX3_S_S_Other
    {
        [XmlElement("Id")]
        public string Id { get; set; }
    }

    public class MX3_S_S_DebtorAgent
    {
        [XmlElement("FinInstnId")]
        public string FinInstnId { get; set; } // Change to a proper class if needed
    }

    public class MX3_S_S_CreditorAgent
    {
        [XmlElement("FinInstnId")]
        public MX3_S_S_FinancialInstitutionId FinInstnId { get; set; }
    }

    public class MX3_S_S_FinancialInstitutionId
    {
        [XmlElement("Nm")]
        public string Name { get; set; }
    }

    public class MX3_S_S_Creditor
    {
        [XmlElement("Nm")]
        public string Name { get; set; }

        [XmlElement("PstlAdr")]
        public MX3_S_S_PostalAddress PstlAdr { get; set; }
    }

    public class MX3_S_S_PostalAddress
    {
        [XmlElement("TwnNm")]
        public string TownName { get; set; }

        [XmlElement("Ctry")]
        public string Country { get; set; }
    }

    public class MX3_S_S_CreditorAccount
    {
        [XmlElement("Id")]
        public MX3_S_S_AccountId Id { get; set; }
    }

}
