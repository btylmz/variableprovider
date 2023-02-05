using System;
using System.Runtime.CompilerServices;
using Flee;

namespace VariableProvider
{
    public sealed class VariableProvider
    {
        #region Fields
        private static VariableProvider Instance = null;
        private static object InstanceLock = new object();
        private ConditionalWeakTable<string, object> _cwt = new ConditionalWeakTable<string, object>();
        #endregion

        #region Constructor
        private VariableProvider() { }
        #endregion

        #region Instance 
        public static void CreateInstance()
        {
            if (Instance is null)
            {
                lock (InstanceLock)
                {
                    if (Instance is null)
                    {
                        Instance = new VariableProvider();
                    }
                }

            }
        }
        public static VariableProvider GetInstance()
        {
            return Instance;
        }
        #endregion

        public void CreateVariable(string name, object value = null, object owner = null)
        {
            
        }
    }
}
