
namespace Admin.Core.Service.Admin.Document.Input
{
    public class DocumentUpdateMenuInput : DocumentAddMenuInput
    {
        /// <summary>
        /// ���
        /// </summary>
        public long Id { get; set; }

        /// <summary>
        /// �汾
        /// </summary>
        public long Version { get; set; }
    }
}
