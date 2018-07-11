using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton2
{
    public sealed class Singleton2
    {
        static Singleton2()
        {
        }

        private Singleton2()
        {
        }

        public static Singleton2 Instance { get; } = new Singleton2();
    }

    /*
      private static readonly Singleton2 instance = new Singleton2();

        static Singleton2()
        {
        }

        private Singleton2()
        {
        }

        public static Singleton2 Instance
        {
            get
            {
                return instance;
            }
        }
     */
}
