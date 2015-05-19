using System;

namespace DesignPatternSolution
{
    //第一章 代码无错就是优？ ——简单工厂模式
    /* 
     *1.活字印刷，面向对象，(对酒当歌，人生几何)，可维护_改字，可复用_拆字，可扩展_加字，灵活性_排版.学习面向对象的分析设计编程思想，利
     *  用封装，继承和多态把程序的耦合度降低。
     *
     * 
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

            Console.WriteLine(string.IsNullOrEmpty(msg) ? numResult.ToString() : msg);

            Console.ReadLine();
        }
    }
}
