using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using MedicalInsuranceBase;
namespace MedicalInsuranceBase
{
    public interface IDllOperation
    {
        MedicalInsuranceEntity Operation(MedicalInsuranceEntity entity);
    }
}
