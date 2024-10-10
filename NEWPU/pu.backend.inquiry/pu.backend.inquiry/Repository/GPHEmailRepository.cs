using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using pu.backend.inquiry.Data;
using pu.backend.inquiry.Models.GPHEmail;
using pu.backend.inquiry.Models.GPHEmail.Dto;

namespace pu.backend.inquiry.Repository
{
    public class GPHEmailRepository : IGPHEmailRepository
    {
        private readonly EmailServiceDbContext _emailServiceDbContext;
        protected readonly IConfiguration _configuration;
        private readonly string? _connString;

        public GPHEmailRepository(EmailServiceDbContext emailServiceDbContext, IConfiguration configuration)
        {
            _emailServiceDbContext = emailServiceDbContext;
            _configuration = configuration;
            if (_configuration.GetConnectionString("DefaultConnection") != null)
            {
                _connString = _configuration.GetConnectionString("DefaultConnection");
            }
            else
            {
                _connString = _configuration["DefaultConnection"]?.ToString();
            }
        }

        public async Task<ResponseDto> GetXmlInquiry(string CustomerName, DateTime? DateFromPayment, DateTime? DateToPayment, DateTime? DateFromUpload, DateTime? DateToUpload, string FileName, string Status, int? pageIndex, int? pageSize)
        {
            ResponseDto obj = new ResponseDto();

            try
            {
                var outputParameter = new SqlParameter
                {
                    ParameterName = "@TotalRecord",
                    Direction = System.Data.ParameterDirection.Output,
                    SqlDbType = System.Data.SqlDbType.Int,
                };

                var sqlParams = new[]
                {
                    new SqlParameter
                    {
                        ParameterName ="@CustomerName",
                        Size=70,
                        Value=CustomerName??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.VarChar,
                    },
                    new SqlParameter {
                        ParameterName="@DateFromPayment",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.Date,
                    },
                    new SqlParameter{
                         ParameterName="@DateToPayment",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.Date,
                    },
                    new SqlParameter{
                         ParameterName="@DateFromUpload",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.Date,
                    },
                     new SqlParameter{
                         ParameterName="@DateToUpload",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.Date,
                    },
                      new SqlParameter{
                         ParameterName="@FileName",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.VarChar,
                    },
                      new SqlParameter{
                         ParameterName="@Status",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.VarChar,
                    },
                       new SqlParameter{
                         ParameterName="@pageIndex",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.Int,
                    },
                      new SqlParameter{
                         ParameterName="@pageSize",
                        Value=DateFromPayment??Convert.DBNull,
                        SqlDbType=System.Data.SqlDbType.Int,
                    },

                    outputParameter
                };

                var objR =  _emailServiceDbContext.Set<Usp_GetXmlInquiryModel>().FromSqlRaw("EXEC Usp_GetXmlInquiry @CustomerName, @DateFromPayment, @DateToPayment, @DateFromUpload, @DateToUpload, @Filename, @Status, @pageIndex, @pageSize, @totalRecord OUt", sqlParams).ToList();

               // @CustomerName,	@DateFromPayment ,@DateToPayment ,@DateFromUpload ,@DateToUpload ,	@FileName ,	@pageIndex ,@pageSize ,	@totalRecord OUTPUT


                obj.Data = objR;
                obj.TotalRecord = (int)outputParameter.Value;


            }
            catch (Exception ex)
            {
                throw;

            }
            return obj;

        }
    }
}
