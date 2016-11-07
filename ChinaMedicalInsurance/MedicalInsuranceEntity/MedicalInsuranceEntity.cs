using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceBase
{
    /// <summary>
    /// 医保实体父类，支持序列化
    /// </summary>
    [Serializable]
    public abstract class MedicalInsuranceEntity
    {
        /// <summary>
        /// 实体类型交易类型
        /// </summary>
        public abstract string EntityType
        { get; }
    }
}
