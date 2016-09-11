using SharpKit.Html;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    /// <summary>
    /// The entry point for rendering Test UI.
    /// </summary>
    public static class TestRuntime
    {
        /// <summary>
        /// Initializes Test UI.
        /// </summary>
        /// <param name="root">The optional jquery selector or object. If <c>null</c> document.body is used.</param>
        /// <returns>The instance of test presenter.</returns>
        public static TestPresenter Start(jQuery.jQuery root = null)
        {
            if (root == null)
                root = new jQuery.jQuery(HtmlContext.document.body);
            else
                root = new jQuery.jQuery(root);

            TestPresenter presenter = new TestPresenter();
            presenter.Render(root);
            return presenter;
        }
    }
}
