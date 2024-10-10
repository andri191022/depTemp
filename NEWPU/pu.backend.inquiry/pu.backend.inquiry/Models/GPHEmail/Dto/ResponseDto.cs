namespace pu.backend.inquiry.Models.GPHEmail.Dto
{
    public class ResponseDto
    {
        public bool IsSuccess { get; set; } = true;
        public string Message { get; set; } = "Success";
        public int TotalRecord { get; set; } = 0;
        public List<Usp_GetXmlInquiryModel> Data { get; set; } = new List<Usp_GetXmlInquiryModel>();

    }
}
