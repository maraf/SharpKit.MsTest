using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Provides a base class for the Category attribute.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public abstract class TestCategoryBaseAttribute : Attribute
    {
        /// <summary>
        /// Gets the test category that has been applied to the test.
        /// </summary>
        /// 
        /// <returns>
        /// The test category.
        /// </returns>
        public abstract IList<string> TestCategories { get; }
    }
}
