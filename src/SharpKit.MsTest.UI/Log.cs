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

        public void Info(string format, object parameter1)
        {
            Info(String.Format(format, parameter1));
        }

        public void Info(string format, object parameter1, object parameter2)
        {
            Info(String.Format(format, parameter1, parameter2));
        }
    }
}
