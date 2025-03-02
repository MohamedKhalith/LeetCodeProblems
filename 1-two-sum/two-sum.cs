public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        List<int> sums = new List<int>();
        for(int i=0; i<nums.Length-1;i++){
            for(int j=i+1; j<nums.Length;j++){
                if(nums[i] + nums[j] == target){
                sums.Add(i);
                sums.Add(j);
            }
            }
        }
        return sums.ToArray();
    }
}