using Microsoft.AspNetCore.Http;

namespace Admin.Core.Service.Admin.Document.Input
{
    public class DocumentUploadImageInput
    {
        /// <summary>
        /// �ϴ��ļ�
        /// </summary>
        public IFormFile File { get; set; }

        /// <summary>
        /// �ĵ����
        /// </summary>
        public long Id { get; set; }
    }
}
