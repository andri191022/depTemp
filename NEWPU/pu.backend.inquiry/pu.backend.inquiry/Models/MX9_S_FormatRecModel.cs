using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace pu.backend.inquiry.Models
{

    [XmlRoot(ElementName = "Document", Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.001.001.03")]
    public class MX9_S_FormatRecModel
    {
        [XmlElement(ElementName = "CstmrCdtTrfInitn")]
        public MX9_S_CustomerCreditTransferInitiation CstmrCdtTrfInitn { get; set; }
    }

    public class MX9_S_CustomerCreditTransferInitiation
    {
        [XmlElement(ElementName = "GrpHdr")]
        public MX9_S_GroupHeader GrpHdr { get; set; }

        [XmlElement(ElementName = "PmtInf")]
        public List<MX9_S_PaymentInformation> PmtInf { get; set; }
    }

    public class MX9_S_GroupHeader
    {
        [XmlElement(ElementName = "MsgId")]
        public string MsgId { get; set; }

        [XmlElement(ElementName = "CreDtTm")]
        public DateTime CreDtTm { get; set; }

        [XmlElement(ElementName = "NbOfTxs")]
        public int NbOfTxs { get; set; }

        [XmlElement(ElementName = "InitgPty")]
        public MX9_S_PartyIdentification InitgPty { get; set; }
    }

    public class MX9_S_PaymentInformation
    {
        [XmlElement(ElementName = "PmtInfId")]
        public string PmtInfId { get; set; }

        [XmlElement(ElementName = "PmtMtd")]
        public string PmtMtd { get; set; }

        [XmlElement(ElementName = "ReqdExctnDt")]
        public DateTime ReqdExctnDt { get; set; }

        [XmlElement(ElementName = "Dbtr")]
        public MX9_S_PartyIdentification Dbtr { get; set; }

        [XmlElement(ElementName = "DbtrAcct")]
        public MX9_S_AccountIdentification DbtrAcct { get; set; }

        [XmlElement(ElementName = "DbtrAgt")]
        public MX9_S_FinancialInstitutionIdentification DbtrAgt { get; set; }

        [XmlElement(ElementName = "CdtTrfTxInf")]
        public List<MX9_S_CreditTransferTransactionInformation> CdtTrfTxInf { get; set; }
    }

    public class MX9_S_PartyIdentification
    {
        // Properties can be added based on actual usage
    }

    public class MX9_S_AccountIdentification
    {
        [XmlElement(ElementName = "Id")]
        public MX9_S_OtherIdentification Id { get; set; }
    }

    public class MX9_S_OtherIdentification
    {
        [XmlElement(ElementName = "Othr")]
        public MX9_S_OtherId Othr { get; set; }
    }

    public class MX9_S_OtherId
    {
        [XmlElement(ElementName = "Id")]
        public string Id { get; set; }
    }

    public class MX9_S_FinancialInstitutionIdentification
    {
        [XmlElement(ElementName = "FinInstnId")]
        public MX9_S_FinancialInstitutionId FinInstnId { get; set; }
    }

    public class MX9_S_FinancialInstitutionId
    {
        [XmlElement(ElementName = "Nm")]
        public string Nm { get; set; }
    }

    public class MX9_S_CreditTransferTransactionInformation
    {
        [XmlElement(ElementName = "PmtId")]
        public MX9_S_PaymentIdentification PmtId { get; set; }

        [XmlElement(ElementName = "PmtTpInf")]
        public MX9_S_PaymentTypeInformation PmtTpInf { get; set; }

        [XmlElement(ElementName = "Amt")]
        public MX9_S_Amount Amt { get; set; }

        [XmlElement(ElementName = "ChrgBr")]
        public string ChrgBr { get; set; }

        [XmlElement(ElementName = "CdtrAgt")]
        public MX9_S_FinancialInstitutionIdentification CdtrAgt { get; set; }

        [XmlElement(ElementName = "Cdtr")]
        public MX9_S_Creditor Cdtr { get; set; }

        [XmlElement(ElementName = "CdtrAcct")]
        public MX9_S_AccountIdentification CdtrAcct { get; set; }

        [XmlElement(ElementName = "RgltryRptg")]
        public List<MX9_S_RegulatoryReporting> RgltryRptg { get; set; }

        [XmlElement(ElementName = "RltdRmtInf")]
        public List<MX9_S_RelatedRemittanceInformation> RltdRmtInf { get; set; }

        [XmlElement(ElementName = "RmtInf")]
        public MX9_S_RemittanceInformation RmtInf { get; set; }
    }

    public class MX9_S_PaymentIdentification
    {
        [XmlElement(ElementName = "InstrId")]
        public string InstrId { get; set; }

        [XmlElement(ElementName = "EndToEndId")]
        public string EndToEndId { get; set; }
    }

    public class MX9_S_PaymentTypeInformation
    {
        [XmlElement(ElementName = "LclInstrm")]
        public MX9_S_LocalInstrument LclInstrm { get; set; }
    }

    public class MX9_S_LocalInstrument
    {
        [XmlElement(ElementName = "Prtry")]
        public string Prtry { get; set; }
    }

    public class MX9_S_Amount
    {
        [XmlElement(ElementName = "InstdAmt")]
        public MX9_S_InstructedAmount InstdAmt { get; set; }
    }

    public class MX9_S_InstructedAmount
    {
        [XmlAttribute(AttributeName = "Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }

    public class MX9_S_Creditor
    {
        [XmlElement(ElementName = "Nm")]
        public string Name { get; set; }

        [XmlElement(ElementName = "PstlAdr")]
        public MX9_S_PostalAddress PostalAddress { get; set; }
    }

    public class MX9_S_PostalAddress
    {
        [XmlElement(ElementName = "TwnNm")]
        public string TownName { get; set; }

        [XmlElement(ElementName = "Ctry")]
        public string Country { get; set; }
    }

    public class MX9_S_RegulatoryReporting
    {
        [XmlElement(ElementName = "DbtCdtRptgInd")]
        public string DbtCdtRptgInd { get; set; }

        [XmlElement(ElementName = "Authrty")]
        public MX9_S_Authority Authrty { get; set; }

        [XmlElement(ElementName = "Dtls")]
        public MX9_S_Details Dtls { get; set; }
    }

    public class MX9_S_Authority
    {
        // Add any relevant properties based on actual usage
    }

    public class MX9_S_Details
    {
        [XmlElement(ElementName = "Inf")]
        public string Info { get; set; }
    }

    public class MX9_S_RelatedRemittanceInformation
    {
        [XmlElement(ElementName = "RmtLctnDtls")]
        public MX9_S_RemittanceLocationDetails RmtLctnDtls { get; set; }

        [XmlElement(ElementName = "Mtd")]
        public string Mtd { get; set; }

        [XmlElement(ElementName = "ElctrncAdr")]
        public string ElctrncAdr { get; set; }
    }

    public class MX9_S_RemittanceLocationDetails
    {
        [XmlElement(ElementName = "Mtd")]
        public string Method { get; set; }

        [XmlElement(ElementName = "ElctrncAdr")]
        public string ElectronicAddress { get; set; }
    }

    public class MX9_S_RemittanceInformation
    {
        [XmlElement(ElementName = "Strd")]
        public MX9_S_StructuredRemittanceInformation Strd { get; set; }
    }

    public class MX9_S_StructuredRemittanceInformation
    {
        [XmlElement(ElementName = "RfrdDocInf")]
        public MX9_S_ReferredDocumentInformation RfrdDocInf { get; set; }

        [XmlElement(ElementName = "RfrdDocAmt")]
        public MX9_S_ReferredDocumentAmount RfrdDocAmt { get; set; }

        [XmlElement(ElementName = "CdtrRefInf")]
        public MX9_S_CreditorReferenceInformation CdtrRefInf { get; set; }

        [XmlElement(ElementName = "AddtlRmtInf")]
        public string AddtlRmtInf { get; set; }
    }

    public class MX9_S_ReferredDocumentInformation
    {
        [XmlElement(ElementName = "Nb")]
        public string Number { get; set; }
    }

    public class MX9_S_ReferredDocumentAmount
    {
        [XmlElement(ElementName = "RmtdAmt")]
        public MX9_S_RemittedAmount RmtdAmt { get; set; }
    }

    public class MX9_S_RemittedAmount
    {
        [XmlAttribute(AttributeName = "Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal Value { get; set; }
    }

    public class MX9_S_CreditorReferenceInformation
    {
        [XmlElement(ElementName = "Ref")]
        public string Reference { get; set; }
    }


}

