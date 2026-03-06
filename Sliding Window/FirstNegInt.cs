using System;
using System.Collections.Generic;

/*nput: arr[] = [-8, 2, 3, -6, 1] , k = 2
Output: [-8, 0, -6, -6]
Explanation: First negative integer for each window of size 2
                        [-8, 2] = -8
                        [2, 3]= 0 (does not contain a negative integer)
                        [3, -6] = -6
                        [-6, 10] = -6*/
class GfG
{
    // function to find the first negative integer 
    // in every window of size k
    public static List<int> FirstNegInt(int[] arr, int k) {
       List<int> result=new List<int>();
       Queue<int> q= new Queue<int> ();
       int left=0;
       
       for(int right=0;right<arr.Length;right++)
       {
           if(arr[right]<0)
           {
               q.Enqueue(right);
           }
           if(right-left+1==k)
           {
               if(q.count==0)
                 result.Add(0);
               else
                 result.Add(arr[q.peek()]);
                 
               if(q.count>0 && q.peek()==left)
                 q.Dequeue();
               left++;
           }
       }
       return result;
    }
}