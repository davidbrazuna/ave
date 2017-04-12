using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MapperReflect
{
    public class Mapper<TSrc, TDest> : IMapper
    {
        private readonly Type klassSrc;
        private readonly Type klassDest;
        private readonly Dictionary<String, IMapping> props;

        public Mapper(Type klassSrc, Type klassDest)
        {
            this.klassSrc = klassSrc;
            this.klassDest = klassDest;
        }

        public Mapper<TSrc, TDest> Bind(object src)
        {
            return null;
        }

        
        public object Map(object src)
        {
            throw new NotImplementedException();
        }

        public object[] Map(object[] src)
        {
            throw new NotImplementedException();
        }

        public Mapper<TSrc, TDest> Match(string nameFrom, string nameDest)
        {
            return null;
        }

        
    }

    internal interface IMapping
    {
        void copy(object src, object dest);
    }

   
}
