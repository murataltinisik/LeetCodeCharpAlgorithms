﻿int SearchInsert(int[] nums, int target)
{
    // Variables
    int searchIndex = -1;
    
    // Max Index
    searchIndex = target > nums[nums.Length - 1] ? nums.Length : -1;

    if(searchIndex == -1){
        for (int i = 0; i < nums.Length; i++)
        {
            if(nums[i] == target) searchIndex = i;

            if(nums[i] < target && nums[i + 1] > target) searchIndex = i + 1;
        }
    }
    
    return searchIndex == -1 ? 0 : searchIndex;
}

/*
 * Given a sorted array of distinct integers and a target value, return the index if the target is found. If not, return the index where it would be if it were inserted in order.
   You must write an algorithm with O(log n) runtime complexity.

   Example 1:
   Input: nums = [1,3,5,6], target = 5
   Output: 2

   Example 2:
   Input: nums = [1,3,5,6], target = 2
   Output: 1

   Example 3:
   Input: nums = [1,3,5,6], target = 7
   Output: 4
 */

int[] array = { 1, 3, 5, 6 };
Console.WriteLine("---------------");
Console.WriteLine(SearchInsert(array, 5));
Console.WriteLine("---------------");
Console.WriteLine(SearchInsert(array, 2));
Console.WriteLine("---------------");
Console.WriteLine(SearchInsert(array, 7));
Console.WriteLine("---------------");