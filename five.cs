using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;

namespace C
{
    class five
    {
        static void Main(string[] args)
        {   
            //五、邏輯處理-交集、差集、聯集
            int[] arr1 = { 1, 2, 3, 4, 5 };
            int[] arr2 = { 3, 4, 5, 6, 8 };

            //1.交集 => { 0, 1, 4, 5, 9}
            var intersect = arr1.Intersect(arr2).ToList();
            Console.WriteLine("交集: {0}", string.Join(",",intersect));
            //2.差集 => {77, 22, 13, 55, 97, 796}
            var except1 = arr1.Except(arr2).ToList();
            var except2 = arr2.Except(arr1).ToList();
            Console.WriteLine("差集: {0}", string.Join(",", except1)+","+string.Join(",", except2));
            
            //3.聯集 => {77, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9, 2, 3, 6, 7, 8}
            var union = arr1.Union(arr2).ToList();
            Console.WriteLine("并集: {0}", string.Join(",", union));
        }

    }
}