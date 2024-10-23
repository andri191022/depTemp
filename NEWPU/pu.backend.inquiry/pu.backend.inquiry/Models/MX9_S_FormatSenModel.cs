using System.Xml.Serialization;
using System;
using System.Collections.Generic;


namespace pu.backend.inquiry.Models
{



    [XmlRoot(Namespace = "urn:iso:std:iso:20022:tech:xsd:pain.002.001.03")]
    public class MX9_S_FormatSenModel
    {
        [XmlElement("GrpHdr")]
        public MX9_S_S_GroupHeader GroupHeader { get; set; }

        [XmlElement("OrgnlGrpInfAndSts")]
        public MX9_S_S_OriginalGroupInfoAndStatus OriginalGroupInfoAndStatus { get; set; }

        [XmlElement("OrgnlPmtInfAndSts")]
        public MX9_S_S_OriginalPaymentInfoAndStatus OriginalPaymentInfoAndStatus { get; set; }
    }

    public class MX9_S_S_GroupHeader
    {
        [XmlElement("MsgId")]
        public string MessageId { get; set; }

        [XmlElement("CreDtTm")]
        public DateTime CreationDateTime { get; set; }
    }

    public class MX9_S_S_OriginalGroupInfoAndStatus
    {
        [XmlElement("OrgnlMsgId")]
        public string OriginalMessageId { get; set; }

        [XmlElement("OrgnlMsgNmId")]
        public string OriginalMessageNameId { get; set; }

        [XmlElement("GrpSts")]
        public string GroupStatus { get; set; }

        [XmlElement("StsRsnInf")]
        public MX9_S_S_StatusReasonInfo StatusReasonInfo { get; set; }
    }

    public class MX9_S_S_StatusReasonInfo
    {
        [XmlElement("Rsn")]
        public MX9_S_S_Reason Reason { get; set; }
    }

    public class MX9_S_S_Reason
    {
        [XmlElement("Prtry")]
        public string Proprietary { get; set; }
    }

    public class MX9_S_S_OriginalPaymentInfoAndStatus
    {
        [XmlElement("OrgnlPmtInfId")]
        public string OriginalPaymentInfoId { get; set; }

        [XmlElement("TxInfAndSts")]
        public List<MX9_S_S_TransactionInfoAndStatus> TransactionInfoAndStatus { get; set; }
    }

    public class MX9_S_S_TransactionInfoAndStatus
    {
        [XmlElement("StsId")]
        public string StatusId { get; set; }

        [XmlElement("OrgnlInstrId")]
        public string OriginalInstructionId { get; set; }

        [XmlElement("OrgnlEndToEndId")]
        public string OriginalEndToEndId { get; set; }

        [XmlElement("TxSts")]
        public string TransactionStatus { get; set; }

        [XmlElement("StsRsnInf")]
        public MX9_S_S_StatusReasonInfo StatusReasonInfo { get; set; }

        [XmlElement("OrgnlTxRef")]
        public MX9_S_S_OriginalTransactionReference OriginalTransactionReference { get; set; }
    }

    public class MX9_S_S_OriginalTransactionReference
    {
        [XmlElement("Amt")]
        public MX9_S_S_Amount Amount { get; set; }

        [XmlElement("ReqdExctnDt")]
        public DateTime RequiredExecutionDate { get; set; }

        [XmlElement("DbtrAcct")]
        public MX9_S_S_DebtorAccount DebtorAccount { get; set; }

        [XmlElement("DbtrAgt")]
        public MX9_S_S_DebtorAgent DebtorAgent { get; set; }

        [XmlElement("CdtrAgt")]
        public MX9_S_S_CreditorAgent CreditorAgent { get; set; }

        [XmlElement("Cdtr")]
        public MX9_S_S_Creditor Creditor { get; set; }

        [XmlElement("CdtrAcct")]
        public MX9_S_S_CreditorAccount CreditorAccount { get; set; }
    }

    public class MX9_S_S_Amount
    {
        [XmlElement("InstdAmt")]
        public MX9_S_S_InstructedAmount InstructedAmount { get; set; }
    }

    public class MX9_S_S_InstructedAmount
    {
        [XmlAttribute("Ccy")]
        public string Currency { get; set; }

        [XmlText]
        public decimal AmountValue { get; set; }
    }

    public class MX9_S_S_DebtorAccount
    {
        [XmlElement("Id")]
        public MX9_S_S_AccountId Id { get; set; }
    }

    public class MX9_S_S_AccountId
    {
        [XmlElement("Othr")]
        public string Other { get; set; }
    }

    public class MX9_S_S_DebtorAgent
    {
        [XmlElement("FinInstnId")]
        public string FinancialInstitutionId { get; set; } // Assuming it's a string for now
    }

    public class MX9_S_S_CreditorAgent
    {
        [XmlElement("FinInstnId")]
        public MX9_S_S_FinancialInstitutionId FinancialInstitutionId { get; set; }
    }

    public class MX9_S_S_FinancialInstitutionId
    {
        [XmlElement("Nm")]
        public string Name { get; set; }
    }

    public class MX9_S_S_Creditor
    {
        [XmlElement("Nm")]
        public string Name { get; set; }

        [XmlElement("PstlAdr")]
        public MX9_S_S_PostalAddress PostalAddress { get; set; }
    }

    public class MX9_S_S_PostalAddress
    {
        [XmlElement("TwnNm")]
        public string TownName { get; set; }

        [XmlElement("Ctry")]
        public string Country { get; set; }
    }

    public class MX9_S_S_CreditorAccount
    {
        [XmlElement("Id")]
        public MX9_S_S_CreditorAccountId Id { get; set; }
    }

    public class MX9_S_S_CreditorAccountId
    {
        [XmlElement("Othr")]
        public MX9_S_S_Other Other { get; set; }
    }

    public class MX9_S_S_Other
    {
        [XmlElement("Id")]
        public string Id { get; set; }
    }
}



