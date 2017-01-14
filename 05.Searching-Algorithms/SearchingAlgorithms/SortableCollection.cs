namespace SortingHomework
{
    using System;
    using System.Collections.Generic;

    public class SortableCollection<T> where T : IComparable<T>
    {
        private readonly IList<T> items;

        public SortableCollection()
        {
            this.items = new List<T>();
        }

        public SortableCollection(IEnumerable<T> items)
        {
            this.items = new List<T>(items);
        }

        public IList<T> Items
        {
            get
            {
                return this.items;
            }
        }

        public void Sort(ISorter<T> sorter)
        {
            sorter.Sort(this.items);
        }

        public bool LinearSearch(T item)
        {
            bool result = false;
            foreach (var member in this.Items)
            {
                if (member.CompareTo(item) == 0)
                {
                    result = true;
                }
            }

            return result;
        }

        public bool BinarySearch(T item)
        {
            bool result = false;
            int iMin = 0;
            int iMax = this.Items.Count - 1;
            int iMid = 0;

            while (iMax >= iMin)
            {
                iMid = (iMax + iMin) / 2;
                if (item.CompareTo(this.Items[iMid]) == 0)
                {
                    result = true;
                    break;
                }
                else if (item.CompareTo(this.Items[iMid]) > 0)
                {
                    iMin = iMid + 1;
                }
                else
                {
                    iMax = iMid - 1;
                }
            }

            return result;
        }

        public void Shuffle()
        {
            var n = this.Items.Count;
            var generator = new Random();
            for (int i = 0; i < n; i++)
            {
                int r = i + generator.Next(0, n - i);
                var temp = this.Items[i];
                this.Items[i] = this.Items[r];
                this.Items[r] = temp;
            }
        }

        public void PrintAllItemsOnConsole()
        {
            for (int i = 0; i < this.items.Count; i++)
            {
                if (i == 0)
                {
                    Console.Write(this.items[i]);
                }
                else
                {
                    Console.Write(" " + this.items[i]);
                }
            }

            Console.WriteLine();
        }
    }
}
