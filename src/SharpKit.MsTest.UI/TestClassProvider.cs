using SharpKit.JavaScript;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.UI
{
    public class TestClassProvider
    {
        public List<Type> GetTestClasses()
        {
            List<Type> result = new List<Type>();
            foreach (Type type in GetClasses())
            {

            }

            return result;
        }

        [JsMethod(Code = "return JsCompiler.Types;")]
        private Type[] GetClasses()
        {
            return null;
        }
    }
}
