**QuickSort**

This was a method that takes the right most index and the left most index of an array and then sorts them based on a pivot. \
The pivot is the right most index. It is then sorted based on the pivot. Everything greater then the value is sent to the right 
Everything less than the pivot value is left. It uses this to sort the array based on index value and puts them in order. 

I have traced this below 

**Trace** 

![Image 1](https://cdn.discordapp.com/attachments/583516117201584128/702669318965428234/20200422_165641.jpg)


**Pseudo Code**


ALGORITHM QuickSort(arr, left, right)
    if left < right
        // Partition the array by setting the position of the pivot value 
        DEFINE position <-- Partition(arr, left, right)
        // Sort the left
        QuickSort(arr, left, position - 1)
        // Sort the right
        QuickSort(arr, position + 1, right)
ALGORITHM Partition(arr, left, right)
    // set a pivot value as a point of reference
    DEFINE pivot <-- arr[right]
    // create a variable to track the largest index of numbers lower than the defined pivot
    DEFINE low <-- left - 1
    for i <- left to right do
        if arr[i] <= pivot
            low++
            Swap(arr, i, low)
     // place the value of the pivot location in the middle.
     // all numbers smaller than the pivot are on the left, larger on the right. 
     Swap(arr, right, low + 1)
    // return the pivot index point
     return low + 1
ALGORITHM Swap(arr, i, low)
    DEFINE temp;
    temp <-- arr[i]
    arr[i] <-- arr[low]
    arr[low] <-- temp
