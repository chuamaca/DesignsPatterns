using System;
using System.IO;

namespace Tools
{
    public sealed class Log
    {
        private static Log _instance = null;
        private string _pach;

        //PARA PROTEGER Y TRABJAR ASINCRONAMENTE.
        private static object _protect = new object();

        public static Log GetInstance(string patch)
        {
            lock (_protect)
            {
                if (_instance == null)
                {
                    _instance = new Log(patch);
                }
            }


            return _instance;
        }


        private Log(string patch)
        {
            _pach = patch;
        }

        public void Save(string message)
        {
            File.AppendAllText(_pach, message + Environment.NewLine);
        }
    }
}
