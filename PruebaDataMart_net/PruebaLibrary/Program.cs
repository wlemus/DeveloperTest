// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");


//Order the element in primary array
using PruebaDataMart_net;
using PruebaDataMart_net.BinaryTree;
using System.Collections;

class Program
{
    static void Main(string[] args)
    {
        //********************************MEDIAN***************************************
        //int[] array_int1 = { -2, 0, 1, 2, 3, 4, 6, 9, 10, 13, 20, 35 };
        //int[] array_int2 = { -10, 1, 7, 10, 15, 22 };

        //int[] array_int = { 10, -6, 50, 2, 8, -30, 5, 100, -9, 522, 68, 254, 2, 0, 45, 3, 9, 10 };

        //int[] array_int_media = { 6, 9, 8, 2, 3, 7, 4, 5, 100, -11, 0, -8, 78, 14 };
        //int[] array_int_media_vacia = { 7 }; ;
        //decimal media = Median.find_median(array_int_media);
        //Console.WriteLine(string.Format("La media es:{0}", media));
        //********************************MEDIAN***************************************

        //********************************ANAGRAM***************************************
        //string string1 = "Lácteo";
        //string string2 = "coleta";
        //bool isAnagram = Anagram.isAnagram(string1, string2);
        //Console.WriteLine(string.Format("String 1:{0} and String2:{1} son Anagramas= {2}", string1, string2, isAnagram));

        //********************************BINARY TREE***************************************
        //BinaryTree tree = new BinaryTree();
        //tree.InsertNode(5);
        //tree.InsertNode(30);
        //tree.InsertNode(2);
        //tree.InsertNode(40);
        //tree.InsertNode(25);
        //tree.InsertNode(4);
        //tree.InsertNode(2);

        //Node nodo = tree.SearchNode(5);
        //nodo = tree.SearchNode(2);
        //nodo = tree.SearchNode(4);
        //nodo = tree.SearchNode(40);
        // Console.WriteLine(string.Format("String 1:{0} and String2:{1} son Anagramas= {2}", string1, string2, isAnagram));


        //tree.PrintTree();


        //********************************REMOVE DUPLICATES***************************************
        //List <int> listItems = new List<int> { 4, 2, 3, 1, 6, 4, 3 };
        //List<int>? ResultList = ListsUtils.remove_duplicates(listItems);
        //if (ResultList != null)
        //Console.WriteLine(string.Format("The result list is {0}", ResultList.ToArray()));


        //********************************REMOVE DUPLICATES***************************************
        //List<int> list1 = new List<int>() { 1, 2, 3 };
        //List<int> list2 = new List<int>() { 2, 3, 4 };
        //List<int> list3 = new List<int>() { 3, 4, 5,2 };
        //List<int> list4 = new List<int>() { 3, 4, 5,2 };
        //List<List<int>> lists = new List<List<int>>() { list1, list2, list3, list4 };

        //List<int>? ResultList = ListsUtils.findCommonElements(lists);
        //if (ResultList != null)
        //    Console.WriteLine(string.Format("The result list is {0}", ResultList.ToArray()));


        //********************************REMOVE DUPLICATES***************************************
      
        //List<int> listItems = new List<int>()   { 10, -6, 50, 2, 8, -30, 5, 100, -9, 522, 68, 254, 2, 0, 45, 3, 9, 10 };
        //int value = 258;
        //bool existValue = ListsUtils.ExistsValueByBinarySearch(listItems, value);
        //Console.WriteLine(string.Format("Value exist at list: {0}", existValue));

        //********************************ORDER WITH MERGESORT***************************************

       // List<int> listItems = new List<int>() { 10, -6, 50, 2, 8, -30, 5, 100, -9, 522, 68, 254, 2, 0, 45, 3, 9, 10 };
        List<int> listItems = new List<int>() { 6, 9, 8, 2, 3, 7, 4, 5, 100, -11, 0, -8, 78, 14 };

        List<int> ResultList = ListsUtils.OrderByMergesort(listItems);
       // Console.WriteLine(string.Format("Value exist at list: {0}", existValue));


        Console.WriteLine("END");
    }
}



