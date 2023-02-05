using System;
using System.Collections.Generic;
using System.Text;

namespace VariableProvider.Interfaces
{
    public interface IVariable
    {
        object Owner { get; set; }
        string Key { get; set; }
        object Value { get; set; }
    }
}
