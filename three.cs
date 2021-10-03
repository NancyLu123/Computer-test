using System;
using System.Collections.Generic;
using System.Collections;

namespace C
{
    class three
    {
        static void Main(string[] args)
        {   
            //三、資料處理-陣列
            int[] A = new int[10]{0, 1, 2, 3, 4, 5, 6, 7, 8, 9};
            ArrayList C= new ArrayList();
            ArrayList D = new ArrayList();

            int sum1=0;
            int sum2=0;
  
            for (int i= 0;i <10; i++)
            {
                if((A[i]%2)==1){
                    sum1+=A[i];
                     C.Add(A[i]);
                }else 
                {
                    sum2+=A[i];
                     D.Add(A[i]);

                }
              
            }
            Console.Write(sum1+","+sum2+"\n");
            foreach (int i in C)
            {
                Console.Write("{0} ", i);
            }
            Console.Write("\n");
            foreach (int j in D)
            {
                System.Console.Write("{0} ", j);
            }
        }
    }
}