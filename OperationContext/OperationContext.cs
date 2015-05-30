using System;


namespace OperationLibrary
{
    public class OperationContext
    {
        Operation context;

        public OperationContext(string sign)
        { 
            switch (sign)
            {
                case "+": context = new OperationAdd(); break;
                case "-": context = new OperationSub(); break;
                case "*": context = new OperationMul(); break;
                case "/": context = new OperationDiv(); break;
                case "%": context = new OperationMod(); break;
            }
        }

        public void GetResult(float numX, float numY, ref float numResult,ref string msg)
        {
            context.NumX = numX;
            context.NumY = numY;
            context.CalculateResult(ref numResult,ref msg);        
        }
    }
}
