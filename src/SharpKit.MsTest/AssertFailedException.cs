using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Used to indicate failure for a test.
    /// </summary>
    [Serializable]
    public class AssertFailedException : UnitTestAssertException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"/> class with a specified error message and a reference to the inner exception that is the cause of this exception.
        /// </summary>
        /// <param name="msg">The error message that explains the reason for the exception.</param><param name="ex">The exception that is the cause of the current exception. If the <paramref name="ex"/> parameter is not null, the current exception is raised in a catch block that handles the inner exception.</param>
        public AssertFailedException(string msg, Exception ex)
          : base(msg, ex)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"/> class that uses with a specified error message.
        /// </summary>
        /// <param name="msg">The message that describes the error.</param>
        public AssertFailedException(string msg)
          : base(msg)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.AssertFailedException"/> class.
        /// </summary>
        public AssertFailedException()
        {
        }
    }
}
