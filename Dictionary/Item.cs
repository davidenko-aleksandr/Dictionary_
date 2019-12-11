using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Item<TKey, TValue>
    {
        public TKey Key { get; set; }
        public TValue Value {get; set;}

        public Item() { }

        public Item(TKey key, TValue value)
        {
            if (key==null)
            {
                throw new ArgumentNullException(nameof(key));
            }
            if (value == null)
            {
                throw new ArgumentNullException(nameof(value));
            }
            Key = key;
            Value = value;
        }
        public override string ToString()
        {
            return Value.ToString();
        }
        
    }
}
