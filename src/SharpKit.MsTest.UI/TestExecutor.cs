using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharpKit.MsTest.Metadata;
using SharpKit.JavaScript;

namespace SharpKit.MsTest
{
    public class TestExecutor
    {
        private readonly Log log;

        public TestExecutor(Log log)
        {
            this.log = log;
        }

        public void Run(IEnumerable<TestAssemblyModel> assemblies)
        {
            foreach (TestAssemblyModel assembly in assemblies)
                RunAssembly(assembly);
        }

        private void RunAssembly(TestAssemblyModel assembly)
        {
            log.Info("Starting assembly '{0}'.", assembly.Name);
            InitAssembly(assembly);

            foreach (TestClassModel type in assembly.Classes)
                RunClass(type);

            log.Info("Cleaning assembly '{0}'.", assembly.Name);
            CleanAssembly(assembly);
            log.Info("Ending assembly '{0}'.", assembly.Name);
        }

        private void InitAssembly(TestAssemblyModel assembly)
        { }

        private void CleanAssembly(TestAssemblyModel assembly)
        { }

        private void RunClass(TestClassModel type)
        {
            log.Info("Starting type '{0}'.", type.Type.Name);
            object instance = InitType(type);

            foreach (TestMethodModel method in type.Methods)
                RunMethod(method, instance);

            log.Info("Cleaning type '{0}'.", type.Type.Name);
            CleanType(type, instance);
            log.Info("Ending type '{0}'.", type.Type.Name);
        }

        private object InitType(TestClassModel type)
        {
            return Activator.CreateInstance(type.Type);
        }

        private void CleanType(TestClassModel type, object instance)
        { }

        private void RunMethod(TestMethodModel method, object instance)
        {
            log.Info("Starting method '{0}'.", method.Method.Name);

            try
            {
                method.Method.As<IMethodInfo>().Invoke(instance, new object[0]);
            }
            catch (Exception e)
            {
                log.Info("Exception: {0}", e.ToString());
            }

            log.Info("Ending method '{0}'.", method.Method.Name);
        }

        private interface IMethodInfo
        {
            object Invoke(object instance, object[] parameters);
        }
    }
}
