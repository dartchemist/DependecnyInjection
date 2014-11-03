using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PostSharp.Aspects;

namespace DependencyInjection.Aspects
{
    [Serializable]
    public class NullCheckingAspect : OnMethodBoundaryAspect
    {
        
    }
}
