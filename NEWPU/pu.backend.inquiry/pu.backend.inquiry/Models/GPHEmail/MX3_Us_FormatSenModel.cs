using System.Xml.Serialization;
using System;
using System.Collections.Generic;


namespace pu.backend.inquiry.Models.GPHEmail
{

    [XmlRoot(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.002.001.03")]
    public class MX3_Us_FormatSenModel
    {
        [XmlElement(ElementName = "CstmrPmtStsRpt")]
        public CustomerPaymentStatusReport CstmrPmtStsRpt { get; set; }
    }

    public class CustomerPaymentStatusReport
    {
        [XmlElement(ElementName = "GrpHdr")]
        public GroupHeader GrpHdr { get; set; }

        [XmlElement(ElementName = "OrgnlGrpInfAndSts")]
        public OriginalGroupInformationAndStatus OrgnlGrpInfAndSts { get; set; }

        [XmlElement(ElementName = "OrgnlPmtInfAndSts")]
        public List<OriginalPaymentInformationAndStatus> OrgnlPmtInfAndSts { get; set; }
    }

    public class GroupHeader
    {
        [XmlElement(ElementName = "MsgId")]
        public string MsgId { get; set; }

        [XmlElement(ElementName = "CreDtTm")]
        public DateTime CreDtTm { get; set; }
    }

    public class OriginalGroupInformationAndStatus
    {
        [XmlElement(ElementName = "OrgnlMsgId")]
        public string OrgnlMsgId { get; set; }

        [XmlElement(ElementName = "OrgnlMsgNmId")]
        public string OrgnlMsgNmId { get; set; }

        [XmlElement(ElementName = "GrpSts")]
        public string GrpSts { get; set; }

        [XmlElement(ElementName = "StsRsnInf")]
        public StatusReasonInformation StsRsnInf { get; set; }
    }

    public class OriginalPaymentInformationAndStatus
    {
        [XmlElement(ElementName = "OrgnlPmtInfId")]
        public string OrgnlPmtInfId { get; set; }

        [XmlElement(ElementName = "TxInfAndSts")]
        public List<TransactionInformationAndStatus> TxInfAndSts { get; set; }
    }

    public class TransactionInformationAndStatus
    {
        [XmlElement(ElementName = "StsId")]
        public string StsId { get; set; }

        [XmlElement(ElementName = "OrgnlInstrId")]
        public string OrgnlInstrId { get; set; }

        [XmlElement(ElementName = "OrgnlEndToEndId")]
        public string OrgnlEndToEndId { get; set; }

        [XmlElement(ElementName = "TxSts")]
        public string TxSts { get; set; }

        [XmlElement(ElementName = "StsRsnInf")]
        public StatusReasonInformation StsRsnInf { get; set; }

        [XmlElement(ElementName = "OrgnlTxRef")]
        public OriginalTransactionReference OrgnlTxRef { get; set; }
    }

    public class StatusReasonInformation
    {
        [XmlElement(ElementName = "Rsn")]
        public Reason Rsn { get; set; }

        [XmlElement(ElementName = "AddtlInf")]
        public string AddtlInf { get; set; }
    }

    public class Reason
    {
        [XmlElement(ElementName = "Prtry")]
        public string Prtry { get; set; }
    }

    public class OriginalTransactionReference
    {
        [XmlElement(ElementName = "Amt")]
        public Amount Amt { get; set; }

        [XmlElement(ElementName = "ReqdExctnDt")]
        public DateTime ReqdExctnDt { get; set; }

        [XmlElement(ElementName = "DbtrAcct")]
        public DebtorAccount DbtrAcct { get; set; }

        [XmlElement(ElementName = "DbtrAgt")]
        public DebtorAgent DbtrAgt { get; set; }

        [XmlElement(ElementName = "CdtrAgt")]
        public CreditorAgent CdtrAgt { get; set; }

        [XmlElement(ElementName = "Cdtr")]
        public Creditor Cdtr { get; set; }

        [XmlElement(ElementName = "CdtrAcct")]
        public CreditorAccount CdtrAcct { get; set; }
    }

    public class Amount
    {
        [XmlElement(ElementName = "InstdAmt")]
        public InstructedAmount InstdAmt { get; set; }
    }

    public class InstructedAmount
    {
        [XmlAttribute(AttributeName = "Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }

    public class DebtorAccount
    {
        [XmlElement(ElementName = "Id")]
        public AccountIdentification Id { get; set; }
    }

    public class CreditorAccount
    {
        [XmlElement(ElementName = "Id")]
        public AccountIdentification Id { get; set; }
    }

    public class AccountIdentification
    {
        [XmlElement(ElementName = "Othr")]
        public OtherIdentification Othr { get; set; }
    }

    public class OtherIdentification
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
    }

    public class DebtorAgent
    {
        [XmlElement(ElementName = "FinInstnId")]
        public FinancialInstitutionId FinInstnId { get; set; }
    }

    public class CreditorAgent
    {
        [XmlElement(ElementName = "FinInstnId")]
        public FinancialInstitutionId FinInstnId { get; set; }
    }

    public class FinancialInstitutionId
    {
        [XmlElement(ElementName = "nm")]
        public string Name { get; set; }
    }

    public class Creditor
    {
        [XmlElement(ElementName = "Nm")]
        public string Name { get; set; }

        [XmlElement(ElementName = "PstlAdr")]
        public PostalAddress PstlAdr { get; set; }
    }

    public class PostalAddress
    {
        [XmlElement(ElementName = "TwnNm")]
        public string TownName { get; set; }

        [XmlElement(ElementName = "Ctry")]
        public string Country { get; set; }
    }
}

