using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MedicalInsuranceDll_Entity
{
    [Serializable]
    public class ClinicRegister : MedicalInsuranceBase.MedicalInsuranceEntity
    {
        public override string EntityType
        {
            get
            {
                return "挂号";
            }
        }

        public string RegisterID
        { get; set; }
    }
}
