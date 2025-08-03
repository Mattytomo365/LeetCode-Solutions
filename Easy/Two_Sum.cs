public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        int[] result = [];
        for(int a = 0; a <= nums.Length - 1; a++){
            for(int b = 0; b <= nums.Length - 1; b++){ // Nested for loop
                if(((nums[a] + nums[b]) == target) && (a != b)){
                    result = [a, b]; 
                }
            }
        }

        return result;    
    }
}