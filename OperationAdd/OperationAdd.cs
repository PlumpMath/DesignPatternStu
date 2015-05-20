using System;

namespace OperationLibrary
{
    public class OperationAdd : Operation
    {
        public override void CalculateResult(ref float numResult, ref string msg)
        {
            numResult = NumX + NumY;
        }
    }
}
