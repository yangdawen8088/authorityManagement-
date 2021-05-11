using Admin.Core.Model.Admin;

namespace Admin.Core.Service.Admin.Document.Input
{
    public class DocumentAddGroupInput
    {
        /// <summary>
        /// �����ڵ�
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public DocumentType Type { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// ��
        /// </summary>
        public bool? Opened { get; set; }
    }
}
