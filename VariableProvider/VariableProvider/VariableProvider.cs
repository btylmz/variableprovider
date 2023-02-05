using System;
using Flee;

namespace VariableProvider
{
    public sealed class VariableProvider
    {
        #region Fields
        private static VariableProvider Instance = null;
        private static object InstanceLock = new object();
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

        #endregion
    }
}
