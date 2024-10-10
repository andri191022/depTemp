using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage;
using pu.backend.inquiry.Models.GPHEmail;

namespace pu.backend.inquiry.Data
{
    public class EmailServiceDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public DbSet<Usp_GetXmlInquiryModel> usp_GetXmlInquiryModels { get; set; }
        public EmailServiceDbContext(DbContextOptions<EmailServiceDbContext> options, IConfiguration configuration) : base(options)
        {
            try
            {
                _configuration = configuration;

                var dbCreator = Database.GetService<IRelationalDatabaseCreator>() as RelationalDatabaseCreator;
                if (dbCreator != null && !dbCreator.CanConnect())
                {
                    dbCreator.Create();
                }
            }
            catch (Exception e)
            {
                throw;
            }
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            try
            {
                string? _connString;
                if (_configuration.GetConnectionString("DefaultConnection") != null)
                {
                    _connString = _configuration.GetConnectionString("DefaultConnection");
                }
                else
                {
                    _connString = _configuration["DefaultConnection"]?.ToString();
                }

                if (!optionsBuilder.IsConfigured && !string.IsNullOrEmpty(_connString))
                {
                    optionsBuilder.UseSqlServer(_connString);
                }
            }
            catch (Exception e)
            {
                throw;
            }


        }

    }
}
