// Given an array of integers, return indices of the two numbers such that they add up to a specific target.

// You may assume that each input would have exactly one solution, and you may not use the same element twice
/**
 * @param {number[]} nums
 * @param {number} target
 * @return {number[]}
 */
var twoSum = function(nums, target) {
    var obj = nums.reduce(function(acc, cur, i) {
        acc[cur] = i;
        return acc;
    }, {});
    var result = null;
    for(var index = 0; index < nums.length; index++){
       var item = nums[index];
       if(index != obj[target-item] && obj[target - item] !== undefined) {
           console.log([index, obj[target - item]]);
           result = [index, obj[target - item]];
           break;
       } 
    };
    return result;
};