using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.Results
{
    public class TestMethodResultModel
    {
        public string MethodUniqueId { get; private set; }

        public int ElapsedMilliseconds { get; private set; }
        public TestMethodResultStatus Status { get; private set; }

        public string Message { get; private set; }

        public TestMethodResultModel(string methodUniqueId, int elapsedMilliseconds, TestMethodResultStatus status, string message = null)
        {
            MethodUniqueId = methodUniqueId;
            ElapsedMilliseconds = elapsedMilliseconds;
            Status = status;
            Message = message;
        }
    }
}
