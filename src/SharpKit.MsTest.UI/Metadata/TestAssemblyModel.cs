using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.Metadata
{
    public class TestAssemblyModel
    {
        private readonly List<TestClassModel> classes;

        public string Name { get; private set; }
        public IReadOnlyList<TestClassModel> Classes
        {
            get { return classes; }
        }

        public TestAssemblyModel(string name)
        {
            Name = name;
            classes = new List<TestClassModel>();
        }

        public TestAssemblyModel AddClass(TestClassModel type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            classes.Add(type);
            return this;
        }
    }
}
