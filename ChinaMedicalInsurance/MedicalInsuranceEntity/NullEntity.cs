using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceBase
{
    /// <summary>
    /// 空实体类
    /// </summary>
    [Serializable]
    public class NullEntity : MedicalInsuranceEntity
    {
        /// <summary>
        /// 实体交易类型为null
        /// </summary>
        public override string EntityType
        {
            get
            {
                return null;
            }
        }
    }
}
