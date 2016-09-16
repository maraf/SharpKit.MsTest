using SharpKit.MsTest.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    internal class MethodView
    {
        public static class CssClass
        {
            public const string Clear = "clear";
            public const string Container = "mst-method-container";
            public const string Selector = "mst-method-selector";
            public const string Name = "mst-method-name";
            public const string Time = "mst-method-time";
            public const string Status = "mst-method-status";
        }

        private jQuery.jQuery root;

        public TestMethodModel Model { get; private set; }

        public jQuery.jQuery Selector
        {
            get { return root.find("[data-method-id='" + Model.UniqueId + "']").find("input"); }
        }

        public bool IsSelected
        {
            get { return Selector.attr("checked") == "checked"; }
            set
            {
                if (value)
                    Selector.attr("checked", "checked");
                else
                    Selector.removeAttr("checked");
            }
        }

        public MethodView(TestMethodModel model)
        {
            Model = model;
        }

        public void Render(StringBuilder html)
        {
            html.AppendFormat("<div class='{0}' data-method-id='{1}'>", CssClass.Container, Model.UniqueId);
            html.AppendFormat("<div class='{0}'></div>", CssClass.Status);
            html.AppendFormat("<div class='{0}'><input id='{1}' type='checkbox' /></div>", CssClass.Selector, Model.UniqueId);
            html.AppendFormat("<div class='{0}'><label for='{1}'>{2}</label></div>", CssClass.Name, Model.UniqueId, Model.Method.Name);
            html.AppendFormat("<div class='{0}'></div>", CssClass.Time);
            html.AppendFormat("<div class='{0}'></div>", CssClass.Clear);
            html.Append("</div>");
        }

        public void Bind(jQuery.jQuery root)
        {
            this.root = root;
        }
    }
}
