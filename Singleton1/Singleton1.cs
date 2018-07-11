using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton1
{
    //Threadsafe implementation
    public sealed class Singleton1
    {
        private static Singleton1 instance = null;
        private static readonly object padlock = new object();

        Singleton1()
        {
        }

        public static Singleton1 Instance {
            get {
                //The thread takes out a lock on a shared object, and then checks whether or not the instance has been created before creating the instance.
                //This takes care of the memory barrier issue (as locking makes sure that all reads occur logically after 
                //the lock acquire, and unlocking makes sure that all writes occur logically before the lock release) and ensures that only one thread will create an instance (as only one thread can be in that part of the code at a time - by the time the second thread enters it,the first thread will have created the instance, so the expression will evaluate to false). Unfortunately, performance suffers as a lock is acquired every time the instance is requested.

                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Singleton1();
                    }
                    return instance;
                }
            }
        }
    }
}
