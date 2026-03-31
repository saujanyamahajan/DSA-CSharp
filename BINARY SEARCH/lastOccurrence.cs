//linear search
function lastOccurrence(arr, target) {
    for (let i = arr.length - 1; i >= 0; i--) {
        if (arr[i] === target) {
            return i;
        }
    }
    return -1;
}



//Binary Search
function lastOccurrenceBinary(arr, target) 
{
    int result = -1;
    int left=0;
    int right=arr.Length-1;
     
     while(left<=right)
     {
        int mid=Math.floor((left+right)/2);
        if(arr[mid]==target)
            result= mid;
            left=mid+1;
        elseif (arr[mid]<target)
            left=mid+1;
        else
            right=mid-1;
     }
    return result;
}


// Unsorted → Linear Search (O(n))
// Sorted → Binary Search (O(log n))