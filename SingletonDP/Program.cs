using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SingletonDP
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton obj = Singleton.GetInstance();

            obj.flag = "The Singleton Obj";

            Singleton objSingleton = Singleton.GetInstance();

            Console.WriteLine(objSingleton.flag);

            objSingleton.flag += " Change";

            Console.WriteLine(obj.flag);

            if(obj == objSingleton)
            {
                Console.WriteLine("Same Object");
            }
            
            Console.ReadLine();
        }
    }

    class Singleton
    {
        public string flag;

        private Singleton()
        {
    
        }

        private static Singleton instance;

        public static Singleton GetInstance()
        {
            if (instance == null)
            {
                instance = new Singleton();
            }
            return instance;
        }
    }
    //不直接给Instance加锁的原因：可能还未实例化。
    //双重Lock的原因：可能多个线程进入P1，这时候只有一个进入P2，其他的被排除在P1.5
    class SingletonLock //Double-Check Locking 懒汉式
    {
        private SingletonLock()
        {
        
        }

        private static SingletonLock instance;

        private static readonly object synObj = new object();

        public static SingletonLock GetInstance()
        {
            if (instance == null)
            {//P1
                lock (synObj)
                {
                    if (instance == null)//P1.5
                    {//P2
                        instance = new SingletonLock();
                    }
                }
            }
            return instance;
        }
    }
    //C#提供一种静态初始化方法，不需要显示的编写线程安全代码。
    //不同之处在于 依赖公共语言运行库 来 初始化变量。 饿汉式
    sealed class SingletonStatic
    {
        private static readonly SingletonStatic instance = new SingletonStatic();

        private SingletonStatic() { }

        public static SingletonStatic GetInstance()
        {
            return instance;
        }
    }
}
