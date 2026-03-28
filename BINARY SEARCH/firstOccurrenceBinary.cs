//linear search 
function firstOccurrence(arr, target) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === target) {
            return i; // first occurrence index
        }
    }
    return -1; // not found
}


//Binary Search
function firstOccurrenceBinary(arr, target) 
{
    int result = -1;
    int left=0;
    int right=arr.Length-1;
     
     while(left<=right)
     {
        int mid=Math.floor((left+right)/2);
        if(arr[mid]==target)
            result= mid;
            right=mid-1;// move left
        elseif (arr[mid]<target)
            left=mid+1;
        else
            right=mid-1;
     }
    return result;
}


// Unsorted → Linear Search (O(n))
// Sorted → Binary Search (O(log n))