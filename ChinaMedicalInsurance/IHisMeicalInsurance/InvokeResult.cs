using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HisMeicalInsurance
{
    /// <summary>
    /// 返回值类型
    /// </summary>
    public class InvokeResult
    {
        /// <summary>
        /// 返回值类型
        /// </summary>
        public InvokeResultType ResultType
        { get; set; }
        /// <summary>
        /// 返回值消息
        /// </summary>
        public string Message
        { get; set; }
    }
}

