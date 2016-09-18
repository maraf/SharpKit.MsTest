using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest
{
    public class Log
    {
        public event Action<string> InfoAdded;

        public void Info(string message)
        {
            if (InfoAdded != null)
                InfoAdded(message);
        }
    }
}
