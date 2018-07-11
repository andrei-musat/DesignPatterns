using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton4
{
    //you can use the System.Lazy<T> type to make the laziness really simple. All you need to do is pass a delegate to the constructor which calls the Singleton constructor - which is done most easily with a lambda expression.
    public sealed class Singleton4
    {
        private static readonly Lazy<Singleton4> lazy = new Lazy<Singleton4>(() => new Singleton4());

        public static Singleton4 Instance { get { return lazy.Value; } }

        private Singleton4()
        {
        }
    }
}
