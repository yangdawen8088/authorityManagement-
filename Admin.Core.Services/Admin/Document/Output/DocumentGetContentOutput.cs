
using Admin.Core.Service.Admin.Document.Input;
using Newtonsoft.Json;

namespace Admin.Core.Service.Admin.Document.Output
{
    public class DocumentGetContentOutput
    {
        /// <summary>
        /// ���
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// �汾
        /// </summary>
        public long Version { get; set; }
    }
}
