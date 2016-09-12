using Microsoft.VisualStudio.TestTools.UnitTesting;
using SharpKit.JavaScript;
using SharpKit.JavaScript.Compilation;
using SharpKit.MsTest.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace SharpKit.MsTest.Metadata
{
    public class TestCaseProvider
    {
        public List<TestAssemblyModel> Load()
        {
            List<Type> types = new List<Type>();
            JsObject typesRaw = GetClasses();
            foreach (string typeName in typesRaw)
            {
                Type type = typesRaw[typeName].As<ClrTypeGetter>()._ClrType;
                try
                {
                    TestClassAttribute attribute = type.GetCustomAttributes(true).OfType<TestClassAttribute>().FirstOrDefault();
                    if (attribute != null)
                        types.Add(type);
                }
                catch (Exception)
                { } // TODO: Handle exceptions.
            }

            List<TestAssemblyModel> models = LoadMetadata(types);
            return models;
        }

        private List<TestAssemblyModel> LoadMetadata(IEnumerable<Type> types)
        {
            Dictionary<string, TestAssemblyModel> result = new Dictionary<string, TestAssemblyModel>();
            foreach (Type type in types)
            {
                string assemblyName = type.As<JsObject>()["_JsType"].As<JsType>().assemblyName;
                TestAssemblyModel assembly;
                if (!result.TryGetValue(assemblyName, out assembly))
                    result[assemblyName] = assembly = new TestAssemblyModel(assemblyName);

                LoadClassMetadata(assembly, type);
            }

            return result.Values.ToList();
        }

        private void LoadClassMetadata(TestAssemblyModel assemblyModel, Type type)
        {
            TestClassModel model = new TestClassModel(type);

            foreach (MethodInfo method in type.GetMethods())
            {
                bool isTestMethod = false;

                List<string> categories = new List<string>();
                object[] attributes = method.GetCustomAttributes(true);
                foreach (Attribute attribute in attributes)
                {
                    TestCategoryBaseAttribute categoryAttribute = attribute as TestCategoryBaseAttribute;
                    if (categoryAttribute != null)
                        categories.AddRange(categoryAttribute.TestCategories);

                    TestMethodAttribute methodAttribute = attribute as TestMethodAttribute;
                    if (methodAttribute != null)
                        isTestMethod = true;
                }

                if (isTestMethod)
                {
                    TestMethodModel methodModel = new TestMethodModel(
                        assemblyModel.Name + "-" + type.FullName + "-" + method.Name, 
                        method, 
                        categories
                    );
                    model.AddMethod(methodModel);
                    continue;
                }

                // TODO: Load cleanup and initialize.
            }

            assemblyModel.AddClass(model);
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
