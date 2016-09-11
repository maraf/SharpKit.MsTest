using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Microsoft.VisualStudio.TestTools.UnitTesting
{
    /// <summary>
    /// Class that is used to specify the category of a unit test.
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    public sealed class TestCategoryAttribute : TestCategoryBaseAttribute
    {
        private IList<string> m_testCategories;

        /// <summary>
        /// Gets the test category that has been applied to the test.
        /// </summary>
        /// 
        /// <returns>
        /// Returns the test category that has been applied to the test.
        /// </returns>
        public override IList<string> TestCategories
        {
            get { return this.m_testCategories; }
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Microsoft.VisualStudio.TestTools.UnitTesting.TestCategoryAttribute"/> class by applying the supplied category to the test.
        /// </summary>
        /// <param name="testCategory">The test category to be applied.</param>
        public TestCategoryAttribute(string testCategory)
        {
            this.m_testCategories = new List<string>(1)
            {
              testCategory
            };
        }
    }
}
