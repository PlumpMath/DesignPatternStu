using OperationLibrary;
using System;

namespace DesignPatternSolution
{
    //第一章 代码无错就是优？ ——简单工厂模式
    /* 
     *1.面向对象，活字印刷，(对酒当歌，人生几何)，可维护_改字，可复用_拆字，可扩展_加字，灵活性_排版.学习面向对象的分析设计编程思想，利
     *  用封装，继承和多态把程序的耦合度降低。
     *
     *2.封装，减复制加复用，业务与界面分离。
     *
     *3.继承 多态 具体操作(加减乘除)分离，修改增加操作，不影响其他的。
     */
    class Program
    {
        static void Main(string[] args)
        {
            float numX, numY, numResult=0; string sign, msg="";

            //Console.WriteLine("Please input number x");
            if (!float.TryParse(Console.ReadLine(), out numX))
            {
                msg += "Error num x ";
            }
            //Console.WriteLine("Please input number y");
            if (!float.TryParse(Console.ReadLine(), out numY))
            {
                msg += "Error num y ";
            }
            //Console.WriteLine("Please input sign");
            sign = Console.ReadLine();

            #region P1
            //CalculateResult(numX, numY, sign, ref numResult, ref msg);

            //OperationOld.CalculateResult(numX, numY, sign, ref numResult, ref msg); 
            #endregion

            #region P2

            //Operation operaObj = OperationFactory.CreateOperation(sign);

            //if (operaObj == null) msg += "Error sign ";

            //else
            //{ 
            //    operaObj.NumX = numX; 

            //    operaObj.NumY = numY;

            //    operaObj.CalculateResult(ref numResult, ref msg);
            //}

            #endregion

            #region P3

            OperationContext operaObj = new OperationContext(sign);

            if (operaObj == null)
            {
                msg += "Error sign ";
            }
            else
            {
                operaObj.GetResult(numX, numY, ref numResult, ref msg);
            }

            #endregion

            Console.WriteLine(string.IsNullOrEmpty(msg) ? numResult.ToString() : msg);

            Console.ReadLine();
        }

        public class OperationOld
        {
            public static void CalculateResult(float numX, float numY, string sign, ref float numResult, ref string msg)
            {
                switch (sign)
                {
                    case "+": numResult = numX + numY; break;
                    case "-": numResult = numX - numY; break;
                    case "*": numResult = numX * numY; break;
                    case "/":
                        if (numY != 0)
                            numResult = numX / numY;
                        else
                        {
                            msg += "Divide 0 Error ";
                            numResult = 0;
                        }
                        break;
                    default: msg += "Error sign "; break;
                }
            }
        }

        /*
        public class Operation
        {
            public float NumX { get; set; }
            public float NumY { get; set; }
            public virtual void CalculateResult(ref float numResult, ref string msg){ }
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
        }*/
    }
}
