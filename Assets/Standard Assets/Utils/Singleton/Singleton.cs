﻿using System;
using System.Reflection;

namespace Cofdream.Utils
{
    public abstract class Singleton<T> : ISingleton where T : Singleton<T>
    {
        static Singleton() { }

        protected static T instance;

        protected static object @lock = new object();

        public static T Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (@lock)
                    {

                        var ctors = typeof(T).GetConstructors(BindingFlags.Instance | BindingFlags.NonPublic);

                        var ctor = Array.Find(ctors, c => c.GetParameters().Length == 0);

                        if (ctor == null)
                        {
                            throw new Exception("Non Constructor() not found! in " + typeof(T));
                        }

                        instance = ctor.Invoke(null) as T;
                        instance.SingletonInit();

                        @lock = null;
                    }
                }
                return instance;
            }
        }

        protected virtual void SingletonInit() { }

        public virtual void SingletonFree()
        {
            instance = null;
            Free();
        }

        public abstract void Free();
    }
}
