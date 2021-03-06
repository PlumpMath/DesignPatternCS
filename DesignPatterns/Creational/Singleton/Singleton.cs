﻿/// <summary>
/// Singleton pattern is one of the simplest patterns. This ensures that a class has only one instance and provides a global point of access to it
/// 
/// Singleton This is a class which is responsible for creating and maintaining its own unique instance.
/// </summary>

namespace DesignPatterns.Creational.Singleton
{
    //eager initialization of singleton
    public class SingletonEager
    {
        private static SingletonEager instance = new SingletonEager();
        private SingletonEager() { }
        public static SingletonEager Get { get { return instance; } }
    }

    //lazy initialization of singleton
    public class SingletonLazy
    {
        private static SingletonLazy instance = null;
        private SingletonLazy() { }

        public static SingletonLazy Get
        {
            get
            {
                if (instance == null)
                    instance = new SingletonLazy();
                return instance;
            }
        }
    }

    //thread-safe (double checked locking) initialization of singleton
    public class SingletonSafe
    {
        private static SingletonSafe instance = null;
        private SingletonSafe() { }
        private static object lockThis = new object();
        public static SingletonSafe Get
        {
            get
            {
                lock(lockThis)
                {
                    if (instance == null)
                        instance = new SingletonSafe();
                    return instance;
                }
            }
        }
    }
}
