using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntroToOOpCSharp
{
    //TODO: to be explained
    public interface ISortable
    {
        int SortOrder { get; }
    }

    //TODO: to be explained
    public static class ISortableExtensions
    {
        public static ISortable[] Sort(this ISortable[] sortableCollection)
        {
            for (int i = 0; i < sortableCollection.Length; i++)
            {
                for (int j = 0; j < sortableCollection.Length; j++)
                {
                    if (sortableCollection[i].SortOrder < sortableCollection[j].SortOrder)
                    {
                        ISortable temp = sortableCollection[i];
                        sortableCollection[i] = sortableCollection[j];
                        sortableCollection[j] = temp;
                    }
                }
            }

            return sortableCollection;
        }
    }
}
