using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaDataMart_net
{
    public static class ListsUtils
    {
        /*******************************************remove_duplicates**************************************/
        public static List<int>? remove_duplicates(List<int> elementsList)
        {
            List<int>? resultList = null;

            if (elementsList == null)
                throw new ArgumentNullException("List can't be empty");

            resultList = new List<int>(new HashSet<int>(elementsList));

            return resultList;
        }

        /*******************************************findCommonElements**************************************/
        public static List<int>? findCommonElements(List<List<int>> elementsList)
        {
            List<int>? resultList = null;

            if (elementsList == null)
                throw new ArgumentNullException("List can't be empty");

            if (elementsList.Count == 0)
                return null;

            HashSet<int> commonElements = elementsList.Aggregate
            (new HashSet<int>(elementsList.First()),
                (x, y) =>
                {
                    x.IntersectWith(y);
                    return x;
                });

            if (commonElements != null)
                resultList = new List<int>(commonElements);


            return resultList;
        }

        /*******************************************ExistsValueByBinarySearch**************************************/
        public static bool ExistsValueByBinarySearch(List<int> elementsList, int value)
        {
            bool ExistsValue = false;

            if (elementsList == null)
                throw new ArgumentNullException("List can't be empty");

            elementsList = elementsList.OrderBy(x => x).ToList(); //order ascendent

            return ExistsValueByBinarySearchRecursive(elementsList, value);


            return ExistsValue;
        }
        private static bool ExistsValueByBinarySearchRecursive(List<int> elementsList, int value)
        {
            if (elementsList.Count == 0)
                return false;

            int halfList = ((elementsList.Count) / 2);
            int centralItem = elementsList[halfList];

            if (centralItem == value)
                return true;
            else if (centralItem < value)
                ExistsValueByBinarySearchRecursive(elementsList.GetRange(halfList + 1, elementsList.Count - halfList - 1), value);
            else if (centralItem > value)
                ExistsValueByBinarySearchRecursive(elementsList.GetRange(0, halfList), value);

            return false;
        }

        /*******************************************OrderByMergesort**************************************/
        public static List<int> OrderByMergesort(List<int> elementsList)
        {
            List<int> resultList = new List<int>();
           
                if (elementsList == null)
                    throw new ArgumentNullException("List can't be empty");

                if (elementsList.Count == 0)
                    return resultList;

                resultList = OrderByMergesortRecursive(elementsList);
          
            return resultList;
        }


        private static List<int> OrderByMergesortRecursive(List<int> elementsList)
        {
            List<int> resultList = new List<int>();

            if (elementsList.Count == 1)
                return elementsList;

            int halfList = ((elementsList.Count) / 2);

            List<int> SortedRightList = OrderByMergesortRecursive(elementsList.GetRange(halfList, elementsList.Count - halfList));
            List<int> SortedLeftList = OrderByMergesortRecursive(elementsList.GetRange(0, halfList));

            resultList = MergeListsMergesorte(SortedRightList, SortedLeftList);

            return resultList;
        }
        private static List<int> MergeListsMergesorte(List<int> SortedRightList, List<int> SortedLeftList)
        {
            List<int> resultListSort = new List<int>();
            while (SortedLeftList.Count > 0 && SortedRightList.Count > 0)
            {
                if (SortedLeftList[0] > SortedRightList[0])
                {
                    resultListSort.Add(SortedRightList[0]);
                    SortedRightList.RemoveAt(0);
                }
                else
                {
                    resultListSort.Add(SortedLeftList[0]);
                    SortedLeftList.RemoveAt(0);
                }
            }

            while (SortedRightList.Count > 0)
            {
                resultListSort.Add(SortedRightList[0]);
                SortedRightList.RemoveAt(0);
            }
            while (SortedLeftList.Count > 0)
            {
                resultListSort.Add(SortedLeftList[0]);
                SortedLeftList.RemoveAt(0);
            }
            return resultListSort;
        }

    }
}
