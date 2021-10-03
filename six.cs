using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C
{
    class six
    {
        static void Main(string[] args)
        {   
            int k,k1;
            Console.WriteLine("請輸入大小:\n（必須大於等於2，小於等於103）");
            int length=int.Parse( Console.ReadLine() );
            Console.WriteLine("請輸入一整數：\n（必須介於-109~109之間）");
            int target=int.Parse( Console.ReadLine() );

            int[] b = new int[length];
           

            Console.WriteLine("請輸入"+length+"個整數值到陣列裡：\n(數字大小必須介於-109~109之間)");

            for (k = 0; k < length; k++)
            {
                Console.Write("第{0}個陣列元素:b[{1}]=", k + 1, k);
                b[k] = int.Parse( Console.ReadLine() );
            }

            //for (k1 = 0; k1 < length; k1++)
            //{
                //Console.WriteLine("b[{0}]={1}", k1, b[k1]);
            //}
            int[] res=TwoSum(b,target);
            
            //Console.Read();
            for(int q=0;q<res.Length;q++){
                Console.WriteLine(res[q]);
            } 

        
            
        }

        public static int[] TwoSum(int[] nums, int target) {
            //六、兩數總和 
            int[] ans = new int[2];
            for(int i=0;i<nums.Length;i++){
                for(int j=i+1;i<nums.Length;j++){
                    if((nums[i]+nums[j])==target){
                        ans[0]=i;
                        ans[1]=j;
                        return ans;
                    }
                }
            }
            return  ans;

        }
    }
}