using System;


namespace OperationLibrary
{
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
                case "%": returnObj = new OperationMod(); break;
            }

            return returnObj;
        }
    }
}
