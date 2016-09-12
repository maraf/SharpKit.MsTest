using SharpKit.JavaScript;
using SharpKit.JavaScript.Compilation;
using SharpKit.MsTest.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    public class TestPresenter
    {
        private readonly TestCaseProvider testClassProvider = new TestCaseProvider();

        public void Render(jQuery.jQuery root)
        {
            List<TestAssemblyModel> assemblies = testClassProvider.Load();
            StringBuilder html = new StringBuilder();
            if (assemblies.Count == 0)
            {
                html.Append("No test classes found.");
            }
            else
            {
                foreach (TestAssemblyModel assembly in assemblies)
                {
                    html.Append("<strong>" + assembly.Name + "</strong>");
                    html.Append("<br />");

                    foreach (TestTypeModel type in assembly.Classes)
                    {
                        html.Append(type.Type.Name);
                        html.Append("<br />");
                    }

                    html.Append("<hr />");
                }
            }

            root.html(html.ToString());
        }
    }
}
