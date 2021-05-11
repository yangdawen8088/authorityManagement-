
namespace Admin.Core.Service.Admin.Document.Input
{
    public class DocumentUpdateContentInput
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
        /// Html
        /// </summary>
        public string Html { get; set; }

        /// <summary>
        /// �汾
        /// </summary>
        public long Version { get; set; }
    }
}
