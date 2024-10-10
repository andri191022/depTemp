using System.ComponentModel.DataAnnotations;

namespace pu.backend.inquiry.Models.GPHEmail
{
    public class Usp_GetXmlInquiryModel
    {
        [Key]
        public int RowNumber { get; set; }
        public string? MessageId {  get; set; } 
        public string?ReceivedFileName { get; set; }    
        public int TransactionId { get; set; }
        public string? CustomerName {  get; set; }  
        public string? CustomerRef { get; set; }
        public string? Ccy { get; set; }
        public string? Amount { get; set; }
        public string? PaymentType { get; set; }
        public DateTime? ValueDate { get; set; }
        public string? StatusDesc { get; set; }
    }
}
