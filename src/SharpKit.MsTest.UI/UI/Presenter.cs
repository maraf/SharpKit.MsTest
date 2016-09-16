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
        private MainView mainView;
        private ControlView controls;
        private GroupView groupView;

        public void Render(jQuery.jQuery root)
        {
            List<TestAssemblyModel> assemblies = testClassProvider.Load();

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
            throw new NotImplementedException();
        }

        private void OnRunSelected()
        {
            throw new NotImplementedException();
        }
    }
}
