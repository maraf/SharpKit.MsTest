using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpKit.jQuery;

namespace SharpKit.MsTest.UI
{
    public class ControlView
    {
        public static class CssClass
        {
            public const string All = "mst-run-all";
            public const string Selected = "mst-run-selected";
        }

        private readonly jQuery.jQuery root;

        public event Action RunAll;
        public event Action RunSelected;

        public jQuery.jQuery RunAllButton
        {
            get { return root.find("." + CssClass.All); }
        }

        public jQuery.jQuery RunSelectedButton
        {
            get { return root.find("." + CssClass.Selected); }
        }

        public ControlView(jQuery.jQuery root)
        {
            this.root = root;
        }

        public void Render()
        {
            StringBuilder html = new StringBuilder();
            html.AppendFormat("<button class='{0}'>Run selected</button>", CssClass.Selected);
            html.AppendFormat("<button class='{0}'>Run all</button>", CssClass.All);

            root.html(html.ToString());
            Bind();
        }

        private void Bind()
        {
            RunAllButton.click(OnRunAllClicked);
            RunSelectedButton.click(OnRunSelectedClicked);
        }

        private void OnRunAllClicked()
        {
            if (RunAll != null)
                RunAll();
        }

        private void OnRunSelectedClicked()
        {
            if (RunSelected != null)
                RunSelected();
        }
    }
}
