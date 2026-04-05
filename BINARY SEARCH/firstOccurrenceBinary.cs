//linear search 
function firstOccurrence(arr, target) {
    for (let i = 0; i < arr.length; i++) {
        if (arr[i] === target) {
            return i; // first occurrence index
        }
    }
    return -1; // not found
}
