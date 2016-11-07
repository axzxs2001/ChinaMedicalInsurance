using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HisMeicalInsurance
{
    /// <summary>
    /// 调用返回值类型
    /// </summary>
    public enum InvokeResultType
    {
        /// <summary>
        /// 成功 1
        /// </summary>
        OK = 1,
        /// <summary>
        /// 无 0
        /// </summary>
        None = 0,
        /// <summary>
        /// 取消 -1
        /// </summary>
        Cancel = -1,
        /// <summary>
        /// 错误 -2
        /// </summary>
        Error = -2,
        /// <summary>
        /// 异常 -3
        /// </summary>
        Exception = -3,
        /// <summary>
        /// 其他  -4
        /// </summary>
        Other = -4
    }
}
