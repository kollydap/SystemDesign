using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Duck
{
    public interface ISortAlgorithm
    {
        void Sort(int[] array);
    }

    public class BubbleSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            // implementation of bubble sort algorithm
        }
    }

    public class QuickSort : ISortAlgorithm
    {
        public void Sort(int[] array)
        {
            // implementation of quick sort algorithm
        }
    }

    public class Sorter
    {
        private ISortAlgorithm _sortAlgorithm;

        public Sorter(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public void SetSortAlgorithm(ISortAlgorithm sortAlgorithm)
        {
            _sortAlgorithm = sortAlgorithm;
        }

        public void Sort(int[] array)
        {
            _sortAlgorithm.Sort(array);
        }
    }

}
