using System.Diagnostics;
using System.Linq;

namespace TheCsprojLibrary
{
    internal class ItemCollectionDisplayProxy<T> where T : ItemTypeBase
    {
        private T[] mArray;

        public ItemCollectionDisplayProxy(ItemCollection<T> collection)
        {
            if (collection != null)
            {
                mArray = collection.ToArray();
            }
        }

        [DebuggerBrowsable(DebuggerBrowsableState.RootHidden)]
        public T[] Array
        {
            get { return mArray; }
            set { mArray = value; }
        }
    }
}