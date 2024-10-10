using MediatR;
using pu.backend.inquiry.Models.GPHEmail.Dto;
using pu.backend.inquiry.Queries;
using pu.backend.inquiry.Repository;

namespace pu.backend.inquiry.Handlers
{
    public class GetXmlInquiryHandler:IRequestHandler<GetXmlInquiryQuery, ResponseDto>
    {
        private readonly IGPHEmailRepository _repository;
        public GetXmlInquiryHandler(IGPHEmailRepository repository)
        {
            _repository = repository;
        }
        public async Task<ResponseDto> Handle(GetXmlInquiryQuery query, CancellationToken cancellationToken)
        {
            return await _repository.GetXmlInquiry(query.CustomerName, query.DateFromPayment, query.DateToPayment, query.DateFromUpload, query.DateToUpload, query.FileName,query.Status, query.PageIndex, query.PageSize);
        }
    }
}
