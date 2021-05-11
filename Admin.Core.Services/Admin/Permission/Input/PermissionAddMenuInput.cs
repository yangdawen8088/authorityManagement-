using Admin.Core.Model.Admin;

namespace Admin.Core.Service.Admin.Permission.Input
{
    public class PermissionAddMenuInput
    {
        /// <summary>
        /// Ȩ������
        /// </summary>
        public PermissionType Type { get; set; }

        /// <summary>
        /// �����ڵ�
        /// </summary>
        public int ParentId { get; set; }

        /// <summary>
        /// ��ͼ
        /// </summary>
        public long? ViewId { get; set; }

        /// <summary>
        /// ���ʵ�ַ
        /// </summary>
        public string Path { get; set; }

        /// <summary>
        /// Ȩ������
        /// </summary>
        public string Label { get; set; }

        /// <summary>
        /// ˵��
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// ����
        /// </summary>
		public bool Hidden { get; set; }

        ///// <summary>
        ///// ����
        ///// </summary>
        //public bool Enabled { get; set; }

        /// <summary>
        /// ͼ��
        /// </summary>
        public string Icon { get; set; }

        /// <summary>
        /// �ɹر�
        /// </summary>
        public bool? Closable { get; set; }

        /// <summary>
        /// ���´���
        /// </summary>
        public bool? NewWindow { get; set; }

        /// <summary>
        /// ��������
        /// </summary>
        public bool? External { get; set; }
    }
}
