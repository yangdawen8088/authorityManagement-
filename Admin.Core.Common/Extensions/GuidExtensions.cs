﻿using System;

namespace Admin.Core.Common.Extensions
{
    public static class GuidExtensions
    {
        /// <summary>
        /// 判断Guid是否为空
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool IsNull(this Guid s)
        {
            return s == Guid.Empty;
        }

        /// <summary>
        /// 判断Guid是否不为空
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static bool NotNull(this Guid s)
        {
            return s != Guid.Empty;
        }

    }
}
