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
    public class Presenter
    {
        private readonly TestCaseProvider testClassProvider = new TestCaseProvider();
        private List<TestAssemblyModel> assemblies;
        private MainView mainView;
        private ControlView controls;
        private GroupView groupView;

        public void Render(jQuery.jQuery root)
        {
            assemblies = testClassProvider.Load();

            mainView = new MainView(root);
            mainView.Render();

            controls = new ControlView(mainView.GetControls());
            controls.RunAll += OnRunAll;
            controls.RunSelected += OnRunSelected;
            controls.Render();

            List<TestClassModel> classes = new List<TestClassModel>();
            foreach (TestAssemblyModel assembly in assemblies)
                classes.AddRange(assembly.Classes);

            jQuery.jQuery content = mainView.GetContent();
            groupView = new GroupView(content);
            groupView.Render(classes);
        }

        private void OnRunAll()
        {
            RunTest(assemblies);
        }

        private void OnRunSelected()
        {
            IEnumerable<TestAssemblyModel> selected = groupView.GetSelected();
            RunTest(selected);
        }

        private void RunTest(IEnumerable<TestAssemblyModel> assemblies)
        {
            Log log = new Log();
            log.InfoAdded += OnLogInfoAdded;

            TestExecutor executor = new TestExecutor(log);
            // TODO: Run classes (and assemblies, because each assembly should have its clear/initialize methods).
        }

        private void OnLogInfoAdded(string message)
        {
            mainView.GetLog().append(message + "<br />");
        }
    }
}
