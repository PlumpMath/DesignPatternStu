using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace OperationLibrary
{
    public class OperationMod : Operation
    {
        public override void CalculateResult(ref float numResult, ref string msg)
        {
            numResult = NumX % NumY;
        }
    
    }
}
