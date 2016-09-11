using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// This is the base class for unit test exceptions.
    /// </summary>
    [Serializable]
    public abstract class UnitTestAssertException : Exception
    {
        private string m_message;

        /// <summary>
        /// Gets a message that describes the current exception.
        /// </summary>
        /// 
        /// <returns>
        /// A message describing the exception.
        /// </returns>
        public override string Message
        {
            get
            {
                if (this.m_message != null)
                    return this.m_message.ToString();
                return base.Message;
            }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.UnitTestAssertException"/> class.
        /// </summary>
        protected UnitTestAssertException()
        {
        }

        internal UnitTestAssertException(string message)
          : this(message, null)
        {
        }

        internal UnitTestAssertException(string message, Exception inner)
          : base(message, inner)
        {
            this.m_message = message;
        }
    }
}
