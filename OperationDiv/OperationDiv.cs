using System;

namespace OperationLibrary
{
    public class OperationDiv : Operation
    {
        public override void CalculateResult(ref float numResult, ref string msg)
        {
            if (NumY != 0) numResult = NumX / NumY;
            else
            {
                msg += "Divide 0 Error "; numResult = 0;

                //throw new Exception("Divide 0 Error");
            }
        }
    }
}
