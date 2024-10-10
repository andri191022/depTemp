using MediatR;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using pu.backend.inquiry.Logic;
using pu.backend.inquiry.Models.GPHEmail;
using pu.backend.inquiry.Models.GPHEmail.Dto;
using pu.backend.inquiry.Queries;
using pu.backend.inquiry.Repository;
using System.IO.Compression;
using System.Text;
using System.Xml;

namespace pu.backend.inquiry.Controllers
{
    [Route("api/[controller]/v1")]
    [ApiController]
    public class GPHEmailController : ControllerBase
    {
        //private readonly IMediator _mediator;
        private readonly IGPHEmailRepository _gphemailRepository;
        public GPHEmailController(IGPHEmailRepository gPHEmailRepository)
        {
            _gphemailRepository = gPHEmailRepository;
        }

        //[HttpGet]
        //[Route("Inquiry")]
        //public async Task<ResponseDto> GetXmlInquiry(string? CustomerName, DateTime? DateFromPayment, DateTime? DateToPayment, DateTime? DateFromUpload, DateTime? DateToUpload, string? FileName, string? Status, int? PageIndex, int? PageSize)
        //{
        //    return await _mediator.Send(new GetXmlInquiryQuery(CustomerName, DateFromPayment, DateToPayment, DateFromUpload, DateToUpload, FileName, Status, PageIndex, PageSize));
        //}


        [HttpGet]
        [Route("InquiryNew")]
        public async Task<ResponseDto> GetXmlInquiryNew(string? CustomerName, DateTime? DateFromPayment, DateTime? DateToPayment, DateTime? DateFromUpload, DateTime? DateToUpload, string? FileName, string? Status, int? PageIndex, int? PageSize)
        {
            return await _gphemailRepository.GetXmlInquiry(CustomerName, DateFromPayment, DateToPayment, DateFromUpload, DateToUpload, FileName, Status, PageIndex, PageSize);  //_mediator.Send(new GetXmlInquiryQuery(CustomerName, DateFromPayment, DateToPayment, DateFromUpload, DateToUpload, FileName, Status, PageIndex, PageSize));
        }



        [HttpPost]
        [DisableRequestSizeLimit]
        [RequestFormLimits(MultipartBodyLengthLimit = int.MaxValue, ValueLengthLimit = int.MaxValue)]
       // [EnableCors("AllowAll")]
        public IActionResult UploadZipFile(IFormFile file)
        {
            using (var stream = file.OpenReadStream())
            {
                using (var zipArchive = new ZipArchive(stream, ZipArchiveMode.Read))
                {
                    foreach (var entry in zipArchive.Entries)
                    {
                        Console.WriteLine($"Found file: {entry.FullName}");
                        // You can also extract the file contents here if needed

                        // Read the file contents
                        using (var fileStream = entry.Open())
                        {
                            using (var reader = new StreamReader(fileStream, Encoding.UTF8))
                            {
                                var fileContent = reader.ReadToEnd();

                                XmlReaderHelper xmlreader = new XmlReaderHelper();
                                Document document = xmlreader.ReadXmlDocument(fileContent);

                                Console.WriteLine($"File content: {fileContent}");
                            }
                        }
                    }
                }
            }
            return Ok("Zip file processed successfully");
        }


    }
}
