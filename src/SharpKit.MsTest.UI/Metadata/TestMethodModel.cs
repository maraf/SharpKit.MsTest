using SharpKit.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.Metadata
{
    public class TestMethodModel
    {
        public string UniqueId { get; private set; }
        public IReadOnlyList<string> Categories { get; private set; }
        public MethodInfo Method { get; private set; }

        public TestMethodModel(string uniqueId, MethodInfo method, IEnumerable<string> categories)
        {
            UniqueId = uniqueId;
            Method = method;

            if (categories == null)
                Categories = new List<string>();
            else
                Categories = new List<string>(categories);
        }

        public void Before(object instance)
        {

        }

        public void After(object instance)
        {

        }
    }
}
