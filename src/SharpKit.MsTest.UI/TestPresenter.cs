using SharpKit.JavaScript;
using SharpKit.JavaScript.Compilation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    public class TestPresenter
    {
        private readonly TestClassProvider testClassProvider = new TestClassProvider();

        public void Render(jQuery.jQuery root)
        {
            List<Type> testClasses = testClassProvider.GetTestClasses();
            StringBuilder html = new StringBuilder();
            if (testClasses.Count == 0)
            {
                html.Append("No test classes found.");
            }
            else
            {
                foreach (Type testClass in testClasses)
                {
                    html.Append(testClass.FullName);
                    html.Append("<br />");
                }
            }

            root.html(html.ToString());
        }
    }
}
