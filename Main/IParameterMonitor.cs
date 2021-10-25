using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarnationVariableSectionPart
{
    interface IParameterMonitor
    {
        float LastEvaluatedTime { get; set; }
        List<object> OldValues { get; set; }
        bool CachedValueChangedInCurrentFrame { get; set; }
        bool IgnoreValueChangeOnce { get; set; }
    }
}