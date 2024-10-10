using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pu.backend.inquiry.Models.GPHEmail.Dto;
using pu.backend.inquiry.Queries;

namespace pu.backend.inquiry.Controllers
{
    [Route("api/[controller]/v1/[action]")]
    [ApiController]
    public class GPHEmailController : ControllerBase
    {
        private readonly IMediator _mediator;
        public GPHEmailController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("Inquiry")]
        public async Task<ResponseDto> GetXmlInquiry(string? CustomerName, DateTime? DateFromPayment, DateTime? DateToPayment, DateTime? DateFromUpload, DateTime? DateToUpload, string? FileName, string? Status, int? PageIndex, int? PageSize)
        {
            return await _mediator.Send(new GetXmlInquiryQuery(CustomerName, DateFromPayment, DateToPayment, DateFromUpload, DateToUpload, FileName, Status, PageIndex, PageSize));
        }

    }
}
