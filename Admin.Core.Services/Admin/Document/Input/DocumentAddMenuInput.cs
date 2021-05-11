using Admin.Core.Model.Admin;

namespace Admin.Core.Service.Admin.Document.Input
{
    public class DocumentAddMenuInput
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
        public string Name { get; set; }

        /// <summary>
        /// ����
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// ˵��
        /// </summary>
        public string Description { get; set; }
    }
}
