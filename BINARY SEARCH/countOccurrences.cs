function firstOccurrence(arr, target) {
    let left = 0, right = arr.length - 1;
    let result = -1;

    while (left <= right) {
        let mid = Math.floor((left + right) / 2);

        if (arr[mid] === target) {
            result = mid;
            right = mid - 1; // move left
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }

    return result;
}

function lastOccurrence(arr, target) {
    let left = 0, right = arr.length - 1;
    let result = -1;

    while (left <= right) {
        let mid = Math.floor((left + right) / 2);

        if (arr[mid] === target) {
            result = mid;
            left = mid + 1; // move right
        } else if (arr[mid] < target) {
            left = mid + 1;
        } else {
            right = mid - 1;
        }
    }

    return result;
}

function countOccurrences(arr, target) {
    let first = firstOccurrence(arr, target);
    if (first === -1) return 0;

    let last = lastOccurrence(arr, target);
    return last - first + 1;
}


console.log(countOccurrences([1, 2, 2, 2, 3, 4], 2)); // 3