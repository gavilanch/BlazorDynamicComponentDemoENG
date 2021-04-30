using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blazor6.Client
{

    public class JSONComponent
    {
        public string Component { get; set; }
        public IDictionary<string, object> Parameters { get; set; }
    }
}
