using SharpKit.JavaScript;
using SharpKit.MsTest.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpKit.jQuery;
using SharpKit.JavaScript.Compilation;

namespace SharpKit.MsTest.UI
{
    // TODO: This could be reused for category. Rename it to GroupView.
    internal class GroupView
    {
        [JsType(Export = false)]
        public static class CssClass
        {
            public const string Clear = "clear";
            public const string Group = "mst-group";
            public const string Header = "mst-group-header";
            public const string HeaderName = "mst-group-name";
            public const string HeaderStatus = "mst-group-status";
            public const string HeaderSelector = "mst-group-selector";
            public const string HeaderTime = "mst-group-Time";
        }

        private readonly jQuery.jQuery root;
        private readonly List<MethodView> methods;

        public jQuery.jQuery MainSelector
        {
            get { return root.find("." + CssClass.Header).find("input"); }
        }

        public GroupView(jQuery.jQuery root)
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
                html.AppendFormat("<div class='{0}'>", CssClass.Header);
                html.AppendFormat("<div class='{0}'></div>", CssClass.HeaderStatus);
                html.AppendFormat("<div class='{0}'><input id='{1}' type='checkbox' /></div>", CssClass.HeaderSelector, type.Type.FullName);
                html.AppendFormat("<div class='{0}'><label for='{1}'>{2}</label></div>", CssClass.HeaderName, type.Type.FullName, type.Type.Name);
                html.AppendFormat("<div class='{0}'></div>", CssClass.HeaderTime);
                html.AppendFormat("<div class='{0}'></div>", CssClass.Clear);
                html.Append("</div>");

                foreach (TestMethodModel method in type.Methods)
                {
                    MethodView view = new MethodView(type, method);
                    view.Render(html);
                    methods.Add(view);
                }

                html.Append("</div>");
            }

            root.html(html.ToString());
            Bind(root);

            foreach (MethodView view in methods)
            {
                view.Bind(root);
            }
        }

        private void Bind(jQuery.jQuery root)
        {
            root.find("." + CssClass.Header).find("input").change(OnHeaderChanged);
        }

        private void OnHeaderChanged()
        {
            foreach (MethodView view in methods)
                view.IsSelected = MainSelector.@is(":checked");
        }

        public IEnumerable<TestAssemblyModel> GetSelected()
        {
            Dictionary<string, TestAssemblyModel> result = new Dictionary<string, TestAssemblyModel>();
            foreach (MethodView view in methods)
            {
                if (view.IsSelected)
                {
                    string assemblyName = view.ClassModel.Type.As<JsObject>()["_JsType"].As<JsType>().assemblyName;
                    TestAssemblyModel assemblyModel;
                    if (!result.TryGetValue(view.ClassModel.Type.FullName, out assemblyModel))
                        result[view.ClassModel.Type.FullName] = assemblyModel = new TestAssemblyModel(assemblyName);

                    TestClassModel classModel = assemblyModel.Classes.FirstOrDefault(c => c.Type.FullName == view.ClassModel.Type.FullName);
                    if (classModel == null)
                    {
                        classModel = new TestClassModel(view.ClassModel.Type);
                        assemblyModel.AddClass(classModel);
                    }

                    classModel.AddMethod(view.Model);
                }
            }

            return result.Values;
        }
    }
}
