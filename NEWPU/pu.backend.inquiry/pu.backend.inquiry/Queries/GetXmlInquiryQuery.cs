using MediatR;
using pu.backend.inquiry.Models.GPHEmail.Dto;

namespace pu.backend.inquiry.Queries
{
    public class GetXmlInquiryQuery : IRequest<ResponseDto>
    {
        public string CustomerName { get; set; }
        public DateTime? DateFromPayment { get; set; }
        public DateTime? DateToPayment { get; set; } 
        public DateTime? DateFromUpload { get; set; }
        public DateTime? DateToUpload { get;  set; }
        public string FileName { get; set; }
        public string Status {  get; set; }
        public int? PageIndex { get; set; }
        public int? PageSize { get; set; }

        public GetXmlInquiryQuery(string customerName, DateTime? dateFromPayment, DateTime? dateToPayment, DateTime? dateFromUpload, DateTime? dateToUpload, string fileName, string status, int? pageIndex, int? pageSize)
        {
            CustomerName = customerName;
            DateFromPayment = dateFromPayment;
            DateToPayment = dateToPayment;
            DateFromUpload = dateFromUpload;
            DateToUpload = dateToUpload;
            FileName = fileName;
            Status = status;
            PageIndex = pageIndex;
            PageSize = pageSize;
        }

    }
}
