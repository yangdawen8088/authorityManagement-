﻿using System;

namespace Admin.Core.Service.Admin.Auth.Output
{
    public class AuthGetVerifyCodeOutput
    {
        /// <summary>
        /// 缓存键
        /// </summary>
        public string Key { get; set; }

        /// <summary>
        /// 图片
        /// </summary>
        public string Img { get; set; }
    }
}
