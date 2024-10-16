using System.Xml.Serialization;
using System;
using System.Collections.Generic;
namespace pu.backend.inquiry.Models
{

    [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.03")]
    public class MX3_S_FormatRecModel
    {
        [XmlElement("CstmrCdtTrfInitn")]
        public CustomerCreditTransferInitiation CstmrCdtTrfInitn { get; set; }
    }

    public class CustomerCreditTransferInitiation
    {
        [XmlElement("GrpHdr")]
        public GroupHeader GrpHdr { get; set; }

        [XmlElement("PmtInf")]
        public PaymentInformation PmtInf { get; set; }
    }

    public class GroupHeader
    {
        [XmlElement("MsgId")]
        public string MsgId { get; set; }

        [XmlElement("CreDtTm")]
        public DateTime CreDtTm { get; set; }

        [XmlElement("NbOfTxs")]
        public int NbOfTxs { get; set; }

        [XmlElement("InitgPty")]
        public string InitgPty { get; set; } // Change to a proper class if needed
    }

    public class PaymentInformation
    {
        [XmlElement("PmtInfId")]
        public string PmtInfId { get; set; }

        [XmlElement("PmtMtd")]
        public string PmtMtd { get; set; }

        [XmlElement("ReqdExctnDt")]
        public DateTime ReqdExctnDt { get; set; }

        [XmlElement("Dbtr")]
        public string Dbtr { get; set; } // Change to a proper class if needed

        [XmlElement("DbtrAcct")]
        public DebtorAccount DbtrAcct { get; set; }

        [XmlElement("DbtrAgt")]
        public DebtorAgent DbtrAgt { get; set; }

        [XmlElement("CdtTrfTxInf")]
        public List<CreditTransferTransactionInformation> CdtTrfTxInf { get; set; }
    }

    public class DebtorAccount
    {
        [XmlElement("Id")]
        public AccountId Id { get; set; }
    }

    public class AccountId
    {
        [XmlElement("Othr")]
        public Other Other { get; set; }
    }

    public class Other
    {
        [XmlElement("Id")]
        public string Id { get; set; }
    }

    public class DebtorAgent
    {
        [XmlElement("FinInstnId")]
        public string FinInstnId { get; set; } // Change to a proper class if needed
    }

    public class CreditTransferTransactionInformation
    {
        [XmlElement("PmtId")]
        public PaymentId PmtId { get; set; }

        [XmlElement("PmtTpInf")]
        public PaymentTypeInformation PmtTpInf { get; set; }

        [XmlElement("Amt")]
        public Amount Amt { get; set; }

        [XmlElement("ChrgBr")]
        public string ChrgBr { get; set; }

        [XmlElement("CdtrAgt")]
        public CreditorAgent CdtrAgt { get; set; }

        [XmlElement("Cdtr")]
        public Creditor Cdtr { get; set; }

        [XmlElement("CdtrAcct")]
        public CreditorAccount CdtrAcct { get; set; }

        [XmlElement("RgltryRptg")]
        public List<RegulatoryReporting> RgltryRptg { get; set; }

        [XmlElement("RltdmRmtInf")]
        public RelatedRemittanceInformation RltdmRmtInf { get; set; }

        [XmlElement("RltdRmtInf")]
        public List<RelatedRemittanceInformation> RltdRmtInf { get; set; }

        [XmlElement("RmtInf")]
        public RemittanceInformation RmtInf { get; set; }
    }

    public class PaymentId
    {
        [XmlElement("InstrId")]
        public string InstrId { get; set; }

        [XmlElement("EndToEndId")]
        public string EndToEndId { get; set; }
    }

    public class PaymentTypeInformation
    {
        [XmlElement("LclInstrm")]
        public LocalInstrument LclInstrm { get; set; }
    }

    public class LocalInstrument
    {
        [XmlElement("Prtry")]
        public string Prtry { get; set; }
    }

    public class Amount
    {
        [XmlElement("InstdAmt")]
        public InstructedAmount InstdAmt { get; set; }
    }

    public class InstructedAmount
    {
        [XmlAttribute("Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal AmountValue { get; set; }
    }

    public class CreditorAgent
    {
        [XmlElement("FinInstnId")]
        public FinancialInstitutionId FinInstnId { get; set; }
    }

    public class FinancialInstitutionId
    {
        [XmlElement("Nm")]
        public string Name { get; set; }
    }

    public class Creditor
    {
        [XmlElement("Nm")]
        public string Name { get; set; }

        [XmlElement("PstlAdr")]
        public PostalAddress PstlAdr { get; set; }
    }

    public class PostalAddress
    {
        [XmlElement("TwnNm")]
        public string TownName { get; set; }

        [XmlElement("Ctry")]
        public string Country { get; set; }
    }

    public class CreditorAccount
    {
        [XmlElement("Id")]
        public AccountId Id { get; set; }
    }

    public class RegulatoryReporting
    {
        [XmlElement("DbtCdtRptgInd")]
        public string DbtCdtRptgInd { get; set; }

        [XmlElement("Authrty")]
        public string Authrty { get; set; } // Change to a proper class if needed

        [XmlElement("Dtls")]
        public RegulatoryDetails Dtls { get; set; }
    }

    public class RegulatoryDetails
    {
        [XmlElement("Inf")]
        public string Inf { get; set; }
    }

    public class RelatedRemittanceInformation
    {
        [XmlElement("RmtLctnMtd")]
        public string RmtLctnMtd { get; set; }

        [XmlElement("RmtLctnElctrncAdr")]
        public string RmtLctnElctrncAdr { get; set; }
    }

    public class RemittanceInformation
    {
        [XmlElement("Ustrd")]
        public string Ustrd { get; set; }

        [XmlElement("Strd")]
        public StructuredRemittanceInformation Strd { get; set; }
    }

    public class StructuredRemittanceInformation
    {
        [XmlElement("RfrdDocInf")]
        public ReferredDocumentInformation RfrdDocInf { get; set; }

        [XmlElement("RfrdDocAmt")]
        public ReferredDocumentAmount RfrdDocAmt { get; set; }

        [XmlElement("CdtrRefInf")]
        public CreditorReferenceInformation CdtrRefInf { get; set; }

        [XmlElement("AddtlRmtInf")]
        public string AddtlRmtInf { get; set; }
    }

    public class ReferredDocumentInformation
    {
        [XmlElement("Nb")]
        public string Nb { get; set; }
    }

    public class ReferredDocumentAmount
    {
        [XmlElement("RmtdAmt")]
        public AmountAmount RmtdAmt { get; set; }
    }

    public class AmountAmount
    {
        [XmlAttribute("Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal AmountValue { get; set; }
    }

    public class CreditorReferenceInformation
    {
        [XmlElement("Ref")]
        public string Ref { get; set; }
    }




}
