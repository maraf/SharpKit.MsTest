using SharpKit.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    internal class MainView
    {
        [JsType(Export = false)]
        public static class CssClass
        {
            public const string Clear = "clear";

            public const string Container = "mst-container";
            public const string Controls = "mst-controls";
            public const string Content = "mst-content";
            public const string Log = "mst-log";
        }

        private readonly jQuery.jQuery root;

        public MainView(jQuery.jQuery root)
        {
            this.root = root;
        }

        public void Render()
        {
            StringBuilder html = new StringBuilder();
            html.AppendFormat("<div class='{0}'>", CssClass.Container);

            html.AppendFormat("<div class='{0}'></div>", CssClass.Controls);
            html.AppendFormat("<div class='{0}'></div>", CssClass.Content);
            html.AppendFormat("<div class='{0}'></div>", CssClass.Log);
            html.AppendFormat("<div class='{0}'></div>", CssClass.Clear);

            html.Append("</div>");
            root.html(html.ToString());
        }

        public jQuery.jQuery GetControls()
        {
            return root.find("." + CssClass.Controls);
        }

        public jQuery.jQuery GetContent()
        {
            return root.find("." + CssClass.Content);
        }

        public jQuery.jQuery GetLog()
        {
            return root.find("." + CssClass.Log);
        }
    }
}
