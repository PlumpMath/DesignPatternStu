using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DesignPatternStrategy
{
    abstract class CashSuper
    {
        public abstract double acceptCash(double money);
    }

    class CashNormal : CashSuper
    {
        public override double acceptCash(double money)
        {
            return money;
        }
    }

    class CashRebate : CashSuper
    {
        private double moneyRebate = 1;

        public CashRebate(double moneyRebate)
        {
            this.moneyRebate = moneyRebate;
        }

        public override double acceptCash(double money)
        {
            return money * moneyRebate;
        }
    }

    class CashContext
    {
        CashSuper cs = null;

        public CashContext(string type)
        {
            switch(type)
            {
                case "0" : cs = new CashNormal();break;
                case "1" : cs = new CashRebate(0.85);break;
                case "2" : cs = new CashReturn(199,100);break;
            }
        }

        public double GetResult(double money)
        {
            return cs.acceptCash(money);
        }
    }

    class CashReturn : CashSuper
    {
        private double moneyCondition = 0;
        private double moneyReturn = 0;
        public CashReturn(double moneyCondition, double moneyReturn)
        {
            this.moneyCondition = moneyCondition;
            this.moneyReturn = moneyReturn;
        }
    
        public override double acceptCash(double money)
        {
 	        money -= Math.Floor(money/moneyCondition)*moneyReturn;
            return money;
        }
}



    abstract class Strategy
    {
        public abstract void AlgorithmInterface();
    }

    class ConcreteStrategyA : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法A实现");
        }
    }

    class ConcreteStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine("算法B实现");
        }
    }

    class Context
    {
        Strategy strategy;

        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }

        public void ContextInterface()
        {
            strategy.AlgorithmInterface();
        }

       
    }

    public class TestMain
    {
        void HiMain()
        {
            Context context;

            context = new Context(new ConcreteStrategyA());

            context.ContextInterface();

            context = new Context(new ConcreteStrategyB());

            context.ContextInterface();
        }
    }
}
