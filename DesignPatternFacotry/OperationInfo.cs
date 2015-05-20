using System;

namespace DesignPatternSolutionExt
{
    public class Operation
    {
        public float NumX { get; set; }
        public float NumY { get; set; }
        public virtual void CalculateResult(ref float numResult, ref string msg) { }
    }

    public class OperationAdd : Operation
    {
        public override void CalculateResult(ref float numResult, ref string msg)
        {
            numResult = NumX + NumY;
        }
    }

    public class OperationSub : Operation
    {
        public override void CalculateResult(ref float numResult, ref string msg)
        {
            numResult = NumX - NumY;
        }
    }

    public class OperationMul : Operation
    {
        public override void CalculateResult(ref float numResult, ref string msg)
        {
            numResult = NumX * NumY;
        }
    }

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

    public class OperationFactory
    {
        public static Operation CreateOperation(string sign)
        {
            Operation returnObj = null;

            switch (sign)
            {
                case "+": returnObj = new OperationAdd(); break;
                case "-": returnObj = new OperationSub(); break;
                case "*": returnObj = new OperationMul(); break;
                case "/": returnObj = new OperationDiv(); break;
            }

            return returnObj;
        }
    }
}
