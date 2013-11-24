using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;

namespace SortingKata
{
    [TestFixture]
    public class SortingTests
    {
        private IEnumerable<int> List(params int[] ints)
        {
            return new List<int>(ints);
        }

        [Test]
        public void CanSort_WithQuicksort()
        {
            CollectionAssert.AreEqual(List(), QuickSort(List()));
            CollectionAssert.AreEqual(List(1), QuickSort(List(1)));
            CollectionAssert.AreEqual(List(1, 2), QuickSort(List(1, 2)));
            CollectionAssert.AreEqual(List(1, 2), QuickSort(List(2, 1)));
            CollectionAssert.AreEqual(List(1, 2, 3), QuickSort(List(1, 2, 3)));
            CollectionAssert.AreEqual(List(1, 2, 3), QuickSort(List(2, 3, 1)));
            CollectionAssert.AreEqual(List(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), QuickSort(List(8, 2, 1, 4, 5, 6, 10, 3, 7, 9)));
        }

        [Test]
        public void CanSort_WithMergesort()
        {
            CollectionAssert.AreEqual(List(), MergeSort(List()));
            CollectionAssert.AreEqual(List(1), MergeSort(List(1)));
            CollectionAssert.AreEqual(List(1, 2), MergeSort(List(1, 2)));
            CollectionAssert.AreEqual(List(1, 2), MergeSort(List(2, 1)));
            CollectionAssert.AreEqual(List(1, 2, 3), MergeSort(List(1, 2, 3)));
            CollectionAssert.AreEqual(List(1, 2, 3), MergeSort(List(2, 3, 1)));
            CollectionAssert.AreEqual(List(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), MergeSort(List(8, 2, 1, 4, 5, 6, 10, 3, 7, 9)));
        }

        [Test]
        public void CanSort_WithInsertionSort()
        {
            CollectionAssert.AreEqual(List(), InsertionSort(List()));
            CollectionAssert.AreEqual(List(1), InsertionSort(List(1)));
            CollectionAssert.AreEqual(List(1, 2), InsertionSort(List(1, 2)));
            CollectionAssert.AreEqual(List(1, 2), InsertionSort(List(2, 1)));
            CollectionAssert.AreEqual(List(1, 2, 3), InsertionSort(List(1, 2, 3)));
            CollectionAssert.AreEqual(List(1, 2, 3), InsertionSort(List(2, 3, 1)));
            CollectionAssert.AreEqual(List(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), InsertionSort(List(8, 2, 1, 4, 5, 6, 10, 3, 7, 9)));

        }
             [Test]
        public void CanSort_WithSelectionSort()
        {
            CollectionAssert.AreEqual(List(), SelectionSort(List()));
            CollectionAssert.AreEqual(List(1), SelectionSort(List(1)));
            CollectionAssert.AreEqual(List(1, 2), SelectionSort(List(1, 2)));
           // CollectionAssert.AreEqual(List(1, 2), SelectionSort(List(2, 1)));
            //CollectionAssert.AreEqual(List(1, 2, 3), SelectionSort(List(1, 2, 3)));
            //CollectionAssert.AreEqual(List(1, 2, 3), SelectionSort(List(2, 3, 1)));
            //CollectionAssert.AreEqual(List(1, 2, 3, 4, 5, 6, 7, 8, 9, 10), SelectionSort(List(8, 2, 1, 4, 5, 6, 10, 3, 7, 9)));
        }

        private IEnumerable MergeSort(IEnumerable<int> list)
        {
            if (!list.Any())
                return list;
            if (list.Count() == 1)
                return list;

            List<int> firstHalf = list.Take(list.Count() / 2).ToList<int>();
            List<int> secondHalf = list.Skip(list.Count() / 2).ToList<int>();

            return Merge((List<int>)MergeSort(firstHalf), (List<int>)MergeSort(secondHalf));
        }

        private IEnumerable<int> Merge(IEnumerable<int> firstSorted, IEnumerable<int> secondSorted)
        {
            if (!firstSorted.Any())
                return secondSorted;
            if (!secondSorted.Any())
                return firstSorted;

            var result = new List<int>();
            int i = 0;
            int j = 0;
            while (i < firstSorted.Count() && j < secondSorted.Count())
            {
                int elemI = firstSorted.ElementAt(i);
                int elemJ = secondSorted.ElementAt(j);
                if (elemI <= elemJ)
                {
                    result.Add(elemI);
                    i++;
                }
                else
                {
                    result.Add(elemJ);
                    j++;
                }
            }

            if (i < firstSorted.Count())
                result.AddRange(firstSorted.Skip(i));
            else
                result.AddRange(secondSorted.Skip(j));

            return result;
        }

        private IEnumerable<int> QuickSort(IEnumerable<int> list)
        {
            if (!list.Any())
                return new List<int>();
            if (list.Count() == 1)
                return list;

            // Create two new lists
            var pivot = list.ElementAt(0);
            var left = new List<int>(); // Elements <= pivot
            var right = new List<int>(); // Elements > pivot
            for (int i = 1; i < list.Count(); i++)
            {
                var element = list.ElementAt(i);
                if (element <= pivot)
                    left.Add(element);
                else
                    right.Add(element);
            }

            return QuickSort(left).Concat(new List<int> { pivot }).Concat(QuickSort(right));
        }

        private IEnumerable<int> InsertionSort(IEnumerable<int> list)
        {
            if (!list.Any())
                return list;
            if (list.Count() == 1)
                return list;

            // Insert the first element into a sorted list
            return Insert(list.ElementAt(0), InsertionSort(list.Skip(1).ToList()));
        }

        private IEnumerable<int> Insert(int elem, IEnumerable<int> sortedList)
        {
            if (!sortedList.Any())
                return new List<int> { elem };

            var result = new List<int>();
            int first = sortedList.ElementAt(0);
            if (elem <= first)
            {
                result.Add(elem);
                return result.Concat(sortedList);
            }
            result.Add(first);
            return result.Concat(Insert(elem, sortedList.Skip(1)));
        }

        private IEnumerable<int> SelectionSort(IEnumerable<int> list)
        {
            if (!list.Any())
                return list;

            if (list.Count() == 1)
                return list;

            // TODO: Select the index where the element is to be inserted?
            var result = new List<int>();
            var min = list.Min();
            var index = list.ToList().IndexOf(min);

            return list;
        }

        // TODO: Bubble sort

        // TODO: Heapsort (monticulo)
    }
}
