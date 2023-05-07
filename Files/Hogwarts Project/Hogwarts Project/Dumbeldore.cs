using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hogwarts_Project
{
    public sealed class Dumbeldore:People
    {
        private static Dumbeldore instance = null;
        private static readonly object padlock = new object();

        public string Message { get; set; }
        public string MessageReceiver { get; set; }
        public DateTime TicketTime { get; set; }
        public static Dumbeldore Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                    {
                        instance = new Dumbeldore();
                    }
                    return instance;
                }
            }
        }
    }


}

