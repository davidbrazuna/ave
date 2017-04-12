using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace MapperReflect
{
    class AutoMapper
    {
        public static IMapper Build(Type klassSrc, Type klassDest)
        {
            return (IMapper)typeof(AutoMapper)
                .GetMethod("Build", Type.EmptyTypes)
                .MakeGenericMethod(klassSrc, klassDest)
                .Invoke(null, null);
        }
    }
}
