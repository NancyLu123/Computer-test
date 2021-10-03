using System;
using System.Collections.Generic;
using System.Collections;

namespace C
{
    class four
    {
        static void Main(string[] args)
        {   
            //四、資料排序-正序
            //題目描述：今有一陣列資料77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9 請寫出正序排列處理程式碼
            int[] arr = new int[] {77, 5, 5, 22, 13, 55, 97, 4, 796, 1, 0, 9}; 
            Array.Sort(arr); 

            Console.WriteLine("Array After Sorting:"); 
            foreach(int value in arr) 
            { 
                Console.Write(value + " "); 
            } 
        }

    }
}