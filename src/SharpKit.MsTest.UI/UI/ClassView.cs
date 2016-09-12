using SharpKit.JavaScript;
using SharpKit.MsTest.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    // TODO: This could be reused for category. Rename it to GroupView.
    internal class ClassView
    {
        [JsType(Export = false)]
        public static class CssClass
        {
            public const string Group = "mst-group";
            public const string Header = "mst-header";
        }

        private readonly jQuery.jQuery root;
        private readonly List<MethodView> methods;

        public ClassView(jQuery.jQuery root)
        {
            this.root = root;
            this.methods = new List<MethodView>();
        }

        public void Render(IEnumerable<TestClassModel> classes)
        {
            StringBuilder html = new StringBuilder();

            foreach (TestClassModel type in classes)
            {
                html.AppendFormat("<div class='{0}'>", CssClass.Group);
                html.AppendFormat("<div class='{0}'>{1}</div>", CssClass.Header, type.Type.Name);

                foreach (TestMethodModel method in type.Methods)
                {
                    MethodView view = new MethodView(method);
                    view.Render(html);
                }

                html.Append("</div>");
            }

            root.html(html.ToString());

            foreach (MethodView view in methods)
            {
                view.Bind(root);
            }
        }
    }
}
