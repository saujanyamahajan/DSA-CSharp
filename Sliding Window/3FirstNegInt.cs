using System;
using System.Collections.Generic;

class GfG
{
    // function to find the first negative integer 
    // in every window of size k
    //Queue = list of negative numbers in current window
    public static List<int> FirstNegInt(int[] arr, int k) {
       List<int> result=new List<int>(); 
       Queue<int> q= new Queue<int> ();  
       int left=0;
       
       for(int right=0;right<arr.Length;right++)
       {
        // step 1 - If it’s negative → push to queue
           if(arr[right]<0)
           {
               q.Enqueue(right); //add indices at the end 
           }
           //Step 2: When window size = k
           if(right-left+1==k)
           {
            //if queue is empty → answer = 0
               if(q.Count==0)
                 result.Add(0);
               else
               //not empty → answer = front element
                 result.Add(arr[q.Peek()]); //retrieves the element at the front of the collection without removing it
                 
               if(q.Count>0 && q.Peek()==left)
                 q.Dequeue(); //remove from the front
               left++;
           }
       }
       return result;
    }
}


//DRY RUN
// arr = [12, -1, -7, 8, -15, 30, 16, 28]
// k = 3

//// the windows will be
// [12, -1, -7] → -1  
// [-1, -7, 8] → -1  
// [-7, 8, -15] → -7  
// [8, -15, 30] → -15  
// [-15, 30, 16] → -15  
// [30, 16, 28] → 0  

// I only care about negative numbers”
// So:
// Whenever I see a negative → I store it


// left = 0
// q = []   (stores indices of negative numbers)
// result = []


// | right | left | arr[right] | Queue (indices) | Window      | Action                    | Result               |
// | ----- | ---- | ---------- | --------------- | ----------- | ------------------------- | -------------------- |
// | 0     | 0    | 12         | []              | [12]        | no neg                    | -                    |
// | 1     | 0    | -1         | [1]             | [12,-1]     | enqueue                   | -                    |
// | 2     | 0    | -7         | [1,2]           | [12,-1,-7]  | window full → add `-1`    | [-1]                 |
// | 3     | 1    | 8          | [2]             | [-1,-7,8]   | add `-1`, remove index 1  | [-1,-1]              |
// | 4     | 2    | -15        | [2,4] → [4]     | [-7,8,-15]  | add `-7`, remove index 2  | [-1,-1,-7]           |
// | 5     | 3    | 30         | [4]             | [8,-15,30]  | add `-15`                 | [-1,-1,-7,-15]       |
// | 6     | 4    | 16         | [4] → []        | [-15,30,16] | add `-15`, remove index 4 | [-1,-1,-7,-15,-15]   |
// | 7     | 5    | 28         | []              | [30,16,28]  | add `0`                   | [-1,-1,-7,-15,-15,0] |
