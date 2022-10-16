using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Demo_MaxContinuousValue
{
	internal class Program
	{
		static void Main(string[] args)
		{
			//Demo_MaxContinousValue
			//陣列裡只會有0, 3，找出連續3的總和
			//例如:
			//[0,3,3,0,0,3,3,3] -> 9
			//[0,3,3,0,0,3,0,3,0,3] -> 6
			//[0,3,0,0] -> 3

			//宣告一維陣列並賦值
			int[] contValueArray = new int[] { 0, 3, 3, 0, 0, 3, 3, 3 };
			//int[] contValueArray = new int[]{0, 3, 3, 0, 0, 3, 0, 3, 0, 3};
			//int[] contValueArray = new int[]{0, 3, 0, 0};


			//取得陣列大小
			int arrayLength = contValueArray.Length;

			//宣告相加的初始值
			int maxSum = contValueArray[0]; //結果中最大連續的加總
			int currentSum = contValueArray[0]; //截至目前的加總

			//取得陣列中的每個是3的值，並相加
			for (int i = 1; i < arrayLength; i++)
			{
				if (contValueArray[i] >= contValueArray[i - 1]) //若i元素大於等於i-1的元素則加入計算
				{
					currentSum += contValueArray[i];

				}
				else
				{
					currentSum = contValueArray[i]; //若上述條件不成立，重新計算，以此元素歸零						 
				}

				if (currentSum > maxSum) //比大小
				{
					maxSum = currentSum;
				}
			}
			Console.WriteLine(maxSum);
		}
	}
}
