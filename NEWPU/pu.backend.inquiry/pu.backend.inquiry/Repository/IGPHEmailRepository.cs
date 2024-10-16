using pu.backend.inquiry.Models;
using pu.backend.inquiry.Models.GPHEmail.Dto;

namespace pu.backend.inquiry.Repository
{
    public interface IGPHEmailRepository
    {
        public Task<ResponseDto> GetXmlInquiry(string CustomerName, DateTime? DateFromPayment, DateTime? DateToPayment, DateTime? DateFromUpload, DateTime? DateToUpload, string FileName, string Status, int? pageIndex, int? pageSize);
        public Task<List<Mst_Setting>> GetMstSetting();
    
    }
}
