using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.Build.Evaluation;

namespace TheCsprojLibrary
{
    [DebuggerTypeProxy(typeof(ItemCollectionDisplayProxy<>))]
    [DebuggerDisplay("Count = {Count}")]
    public class ItemCollection<T> : IEnumerable<T>
        where T : ItemTypeBase
    {
        private readonly Project mProject;

        public ItemCollection(Project project)
        {
            mProject = project;
        }

        public T AddItem(string unevaluatedInclude)
        {
            IList<ProjectItem> addItem = mProject.AddItem(typeof (T).Name, unevaluatedInclude);
            ProjectItem item = addItem.FirstOrDefault();

            if (item == null)
            {
                return null;
            }

            return (T) Activator.CreateInstance(typeof (T), item);
        }

        public bool RemoveItem(T item)
        {
            return mProject.RemoveItem(item.Item);
        }

        public void RemoveItems(IEnumerable<T> items)
        {
            mProject.RemoveItems(items.Select(x => x.Item));
        }

        public IEnumerator<T> GetEnumerator()
        {
            IEnumerable<T> items =
                mProject.Items.Where(x => x.ItemType == typeof (T).Name)
                        .Select(x => (T) Activator.CreateInstance(typeof (T), x))
                        .ToArray();

            return items.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        private int Count
        {
            get
            {
                return this.Count();
            }
        }
    }
}