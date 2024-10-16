using pu.backend.inquiry.Repository;
using System.IO.Compression;

namespace pu.backend.inquiry.Helper
{
    public class ZipUtil
    {
        private readonly IGPHEmailRepository _iGPHEmailRepository;

        public ZipUtil(IGPHEmailRepository iGPHEmailRepository)
        {
            _iGPHEmailRepository = iGPHEmailRepository;
        }

        public  string GetContentFile(ZipArchive zipfile)
        {
            var obj = _iGPHEmailRepository.GetMstSetting();

            return string.Empty;
        }
    }
}
