using System;
namespace C
{
    class two
    {
        static void Main(string[] args)
        {   
			//二、資料處理-字串
            string topic = "人易科技:上 機 測 驗 - 演算法!";

            //1.字元「:」改成全型)
            string one = topic.Replace(":","：");
            Console.Write(one+"\r\n");
            
            //2.去掉中文字間的空白(保留-號兩側空白)
            string two = topic.Replace(" ", String.Empty);
            string[] twoArray=two.Split('-');
            Console.Write(twoArray[0]+" - "+twoArray[1]+"\r\n");

            //3.列印出符號：到-之間的字元
            string[] threeArray = topic.Split(':');
            string[] threeArray2=threeArray[1].Split('-');
            Console.Write(threeArray2[0]);
        }
    }
}