/*
Given a non-empty array of integers nums, every element appears twice except for one. Find that single one.

You must implement a solution with a linear runtime complexity and use only constant extra space.

 

Example 1:

Input: nums = [2,2,1]
Output: 1
Example 2:

Input: nums = [4,1,2,1,2]
Output: 4
Example 3:

Input: nums = [1]
Output: 1
*/
public class Solution {
    public int SingleNumber(int[] nums) {
        var counterDict = new Dictionary<int,int>();
        foreach(var i in nums)
            if(counterDict.ContainsKey(i))
                counterDict[i] +=1;
            else
                counterDict.Add(i , 1);

        return counterDict.FirstOrDefault(x => x.Value == 1).Key;


    }
}