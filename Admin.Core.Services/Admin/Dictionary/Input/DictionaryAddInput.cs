﻿namespace Admin.Core.Service.Admin.Dictionary.Input
{
    /// <summary>
    /// 添加
    /// </summary>
    public class DictionaryAddInput
    {
        /// <summary>
        /// 字典父级
        /// </summary>
		public long ParentId { get; set; }

        /// <summary>
        /// 字典名称
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 字典编码
        /// </summary>
        public string Code { get; set; }

        /// <summary>
        /// 字典值
        /// </summary>
        public string Value { get; set; }

        /// <summary>
        /// 描述
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// 启用
        /// </summary>
		public bool Enabled { get; set; }
    }
}
