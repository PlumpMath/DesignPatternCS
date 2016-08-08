using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Creational.Sample
{
    public class Singleton
    {
        private static Singleton instance = null;
        private static string Name { get; set; }
        private static string IP { get; set; }
        private Singleton()
        {
            Name = "Server 1";
            IP = "192.168.1.23";
        }

        private static object synlock = new object();

        public static Singleton Instance
        {
            get
            {
                lock (synlock)
                {
                    if (Singleton.instance == null)
                        Singleton.instance = new Singleton();
                    return Singleton.instance;
                }
            }
        }

        public void Show()
        {
            Console.WriteLine("Server Information is : Name={0} & IP={1}", IP, Name);
        }
    }
}
