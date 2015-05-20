using System;

namespace OperationLibrary
{
    public class Operation
    {
        public float NumX { get; set; }
        public float NumY { get; set; }
        public virtual void CalculateResult(ref float numResult, ref string msg) { }
    }
}
