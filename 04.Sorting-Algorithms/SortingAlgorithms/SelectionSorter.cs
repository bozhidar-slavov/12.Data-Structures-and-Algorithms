namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SelectionSorter<T> : ISorter<T> where T : IComparable<T>
    {
        public void Sort(IList<T> collection)
        {
            for (int i = 0; i < collection.Count - 1; i++)
            {
                int iMin = i;
                for (int j = i + 1; j < collection.Count; j++)
                {
                    if (collection[j].CompareTo(collection[iMin]) < 0)
                    {
                        iMin = j;
                    }
                }

                if (iMin != i)
                {
                    var smallestElement = collection[iMin];
                    collection[iMin] = collection[i];
                    collection[i] = smallestElement;
                }
            }
        }
    }
}
