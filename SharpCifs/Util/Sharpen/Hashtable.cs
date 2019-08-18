using System.Collections.Generic;
using System.Linq;

namespace SharpCifs.Util.Sharpen
{
    public class Hashtable : Dictionary<object, object>
    {
        public void Put(object key, object value)
        {
            this[key] = value;
        }

        public object Get(object key)
        {
            object value;
            this.TryGetValue(key, out value);
            return value;
        }
    }
}
