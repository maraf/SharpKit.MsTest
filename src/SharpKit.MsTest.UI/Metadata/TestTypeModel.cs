using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.Metadata
{
    public class TestTypeModel
    {
        private readonly List<TestMethodModel> methods;

        public Type Type { get; private set; }
        public IReadOnlyList<TestMethodModel> Methods { get; private set; }

        public TestTypeModel(Type type)
        {
            if (type == null)
                throw new ArgumentNullException("type");

            Type = type;
            methods = new List<TestMethodModel>();
        }

        public TestTypeModel AddMethod(TestMethodModel method)
        {
            if (method == null)
                throw new ArgumentNullException("method");

            methods.Add(method);
            return this;
        }

        public void Before(object instance)
        {

        }

        public void After(object instance)
        {

        }
    }
}
