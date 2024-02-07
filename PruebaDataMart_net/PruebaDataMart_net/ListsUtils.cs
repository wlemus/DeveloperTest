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
            try
            {
                if (elementsList == null)
                    throw new Exception("List can't be empty");

                resultList = new List<int>(new HashSet<int>(elementsList));
            }
            catch (Exception ex)
            {
                Utils.show_message_console(ex.Message, 1);
            }

            return resultList;
        }

        /*******************************************findCommonElements**************************************/
        public static List<int>? findCommonElements(List<List<int>> elementsList)
        {
            List<int>? resultList = null;
            try
            {
                if (elementsList == null)
                    throw new Exception("List can't be empty");


                HashSet<int> commonElements = elementsList.Aggregate
                    (new HashSet<int>(elementsList.First()),
                        (x, y) =>
                        {
                            x.IntersectWith(y);
                            return x;
                        });

                if (commonElements != null)
                    resultList = new List<int>(commonElements);

            }
            catch (Exception ex)
            {
                Utils.show_message_console(ex.Message, 1);
            }
            return resultList;
        }

        /*******************************************ExistsValueByBinarySearch**************************************/
        public static bool ExistsValueByBinarySearch(List<int> elementsList, int value)
        {
            bool ExistsValue = false;
            try
            {
                if (elementsList == null)
                    throw new Exception("List can't be empty");

                elementsList = elementsList.OrderBy(x => x).ToList(); //order ascendent

                return ExistsValueByBinarySearchRecursive(elementsList, value);

            }
            catch (Exception ex)
            {
                Utils.show_message_console(ex.Message, 1);
            }
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
            try
            {
                if (elementsList == null)
                    throw new Exception("List can't be empty");

                resultList= OrderByMergesortRecursive(elementsList);
            }
            catch (Exception ex)
            {
                Utils.show_message_console(ex.Message, 1);
            }
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
        //  private static void merge( List<int> elementsList, int startIndex, int halfList, int endIndex)
        //    {
        //        var arr = elementsList.ToArray();
        //        // Find sizes of two
        //        // subarrays to be merged
        //        int n1 = halfList - startIndex + 1;
        //        int n2 = endIndex - halfList;

        //        // Create temp arrays
        //        int[] L = new int[n1];
        //        int[] R = new int[n2];
        //        int i, j;

        //        // Copy data to temp arrays
        //        for (i = 0; i < n1; ++i)
        //            L[i] = arr[startIndex + i];
        //        for (j = 0; j < n2; ++j)
        //            R[j] = arr[halfList + 1 + j];

        //        // Merge the temp arrays

        //        // Initial indexes of first
        //        // and second subarrays
        //        i = 0;
        //        j = 0;

        //        // Initial index of merged
        //        // subarray array
        //        int k = startIndex;
        //        while (i < n1 && j < n2)
        //        {
        //            if (L[i] <= R[j])
        //            {
        //                arr[k] = L[i];
        //                i++;
        //            }
        //            else
        //            {
        //                arr[k] = R[j];
        //                j++;
        //            }
        //            k++;
        //        }

        //        // Copy remaining elements
        //        // of L[] if any
        //        while (i < n1)
        //        {
        //            arr[k] = L[i];
        //            i++;
        //            k++;
        //        }

        //        // Copy remaining elements
        //        // of R[] if any
        //        while (j < n2)
        //        {
        //            arr[k] = R[j];
        //            j++;
        //            k++;
        //        }
        //    }

        //}
    }
}
