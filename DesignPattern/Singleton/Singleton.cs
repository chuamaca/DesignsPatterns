using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPattern.Singleton
{
    public class Singleton
    {
        private readonly static Singleton _instance = new Singleton();

        public static Singleton Instance
        {

            get
            {
                return _instance;
            }

        }
        //Protegemos que no puedan crear un nuevo objeto
        private Singleton() { }


    }

    public class Una
    {
        private readonly static Una _instance = new Una();
        public static Una Instance
        {
            get
            {
                return _instance;
            }
        }


        private Una()
        {

        }
    }
}
