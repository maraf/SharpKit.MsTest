using Microsoft.VisualStudio.TestTools.UnitTesting;
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
            JsObject types = GetClasses();
            foreach (string typeName in types)
            {
                Type type = types[typeName].As<ClrTypeGetter>()._ClrType;
                try
                {
                    TestClassAttribute attribute = type.GetCustomAttributes(true).OfType<TestClassAttribute>().FirstOrDefault();
                    if (attribute != null)
                        result.Add(type);
                }
                catch (Exception)
                { } // TODO: Handle exceptions.
            }

            return result;
        }

        [JsMethod(Code = "return JsCompiler.Types;")]
        private JsObject GetClasses()
        {
            return null;
        }

        [JsType(Export = false)]
        private class ClrTypeGetter
        {
            public Type _ClrType;
        }
    }
}
