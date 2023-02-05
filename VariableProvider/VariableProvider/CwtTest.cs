using System;
using System.Collections.Generic;
using System.Text;

namespace VariableProvider
{
    class CwtTest
    {
    }

    //public class VariableCollection : ObservableCollection<IVariable>
    //{

    //}
    //public static class VariableProviderExtensions
    //{
    //    public static readonly ConditionalWeakTable<ITestStepParent, VariableCollection> _cwt = new ConditionalWeakTable<ITestStepParent, VariableCollection>();

    //    public static VariableCollection GetVariables(this ITestStepParent owner)
    //    {
    //        return _cwt.GetOrCreateValue(owner);
    //    }
    //    public static void AddVariable(this ITestStepParent owner, IVariable variable)
    //    {
    //        var collection = _cwt.GetOrCreateValue(owner);
    //        collection.Add(variable);
    //    }
    //    public static object GetVariableValue(this ITestStepParent owner, string key)
    //    {
    //        var collection = _cwt.GetOrCreateValue(owner);
    //        var value = collection.First(x => x.Key == key)?.Value;
    //        return value;
    //    }
    //}
}
