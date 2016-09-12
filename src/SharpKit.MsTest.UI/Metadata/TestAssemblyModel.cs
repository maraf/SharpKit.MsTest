using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.Metadata
{
    public class TestAssemblyModel
    {
        private readonly List<TestTypeModel> classes;

        public string Name { get; private set; }
        public IReadOnlyList<TestTypeModel> Classes
        {
            get { return classes; }
        }

        public TestAssemblyModel(string name)
        {
            Name = name;
            classes = new List<TestTypeModel>();
        }

        public TestAssemblyModel AddClass(TestTypeModel type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            classes.Add(type);
            return this;
        }
    }
}
