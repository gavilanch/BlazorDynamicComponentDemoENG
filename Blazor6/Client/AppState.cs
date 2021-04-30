using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor6.Client
{
    public class AppState
    {
        public Action Action { get; set; }
        public Action<Dictionary<string, object>> ActionWithParameters { get; set; }
    }
}
